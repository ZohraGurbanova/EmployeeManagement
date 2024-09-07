using EmployeeManagement.Domain.Entities;
using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.Application.Interfaces;
using EmployeeManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using EmployeeManagement.Domain.Dtos;
using AutoMapper;

namespace Services
{
    public class EmployeeService : CrudService<EmployeeEntity>, IEmployeeService
    {
        private readonly IMapper _mapper;

        public EmployeeService(IEntityRepository<EmployeeEntity> employeeRepository, IMapper mapper) : base(employeeRepository)
        {
            _mapper = mapper;
        }

        public async Task<EmployeeSearchResponseModel> GetEmployeeSearch(EmployeeSearchModel model)
        {

            var query = GetAll();

            if (!string.IsNullOrEmpty(model.Name))
            {
                query = query.Where(e => e.Name.Contains(model.Name));
            }

            if (!string.IsNullOrEmpty(model.Surname))
            {
                query = query.Where(e => e.Surname.Contains(model.Surname));
            }

            if (model.BirthDate.HasValue)
            {
                query = query.Where(e => e.BirthDate >= model.BirthDate.Value);
            }

            var totalCount = await query.CountAsync();
            var employees = await query
                .Skip((model.Page - 1) * model.PageSize)
                .Take(model.PageSize)
                .ToListAsync();

            var result = new EmployeeSearchResponseModel()
            {
                TotalCount = totalCount,
                Page = model.Page,
                PageSize = model.PageSize,
                Employees = _mapper.Map<List<EmployeeDto>>(employees)
            };

            return result;
        }

    }
}
