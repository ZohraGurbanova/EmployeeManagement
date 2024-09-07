using Employee.Domain.Entities;
using EmployeeManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Application.Interfaces
{
    public interface IEmployeeService : IService<EmployeeEntity>
    {
        Task<EmployeeSearchResponseModel> GetEmployeeSearch(EmployeeSearchModel model);
    }
}
