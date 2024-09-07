using Employee.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Persistence
{
    public class EmployeeManagmentDbContext : DbContext
    {
      
        public EmployeeManagmentDbContext(DbContextOptions<EmployeeManagmentDbContext> options)
        : base(options)
        {
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }

       
    }
}
