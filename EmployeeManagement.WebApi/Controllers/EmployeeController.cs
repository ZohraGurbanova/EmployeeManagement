using AutoMapper;
using EmployeeManagement.Domain.Dtos;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Models;
using EmployeeManagment.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task AddEmployee(EmployeeDto dto)
        {
            EmployeeEntity entity = _mapper.Map<EmployeeEntity>(dto);
            await _employeeService.AddAsync(entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> GetEmployee(int id)
        {
            var employee =await _employeeService.FindByIdAsync(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task DeleteEmployee(int id)
        {
             await _employeeService.DeleteByIdAsync(id);
        }

        [HttpPut]
        public async Task UpdateEmployee(EmployeeDto dto)
        {
            EmployeeEntity entity = _mapper.Map<EmployeeEntity>(dto);
            await _employeeService.UpdateAsync(entity);
        }

        [HttpGet("[action]")]
        public async Task<List<EmployeeDto>> GetEmployeeList()
        {
            var employees = await _employeeService.GetListAsync();
            return _mapper.Map<List<EmployeeDto>>(employees);
        }

        [HttpPost("[action]")]
        public async Task<EmployeeSearchResponseModel> GetEmployeeSearch(EmployeeSearchModel model)
        {
            return await _employeeService.GetEmployeeSearch(model);
        }
    }
}
