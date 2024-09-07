using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagement.Domain.Dtos;
using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Application.Map
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeEntity, EmployeeDto>();
            CreateMap<EmployeeDto, EmployeeEntity>();
        }

    }
}
