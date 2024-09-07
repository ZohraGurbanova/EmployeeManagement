
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Persistence;
using EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class CrudRepository<T> : EfEntityRepositoryBase<T>, IEntityRepository<T> where T : class, IEntity, new()
    {
        public CrudRepository(EmployeeManagmentDbContext context) : base(context)
        {
        }
    }
}
