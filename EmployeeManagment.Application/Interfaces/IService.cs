using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmployeeManagment.Application.Interfaces
{
 public  interface IService<T> where T : IEntity
    {
        Task<T> FindByIdAsync(int Id);
        Task<List<T>> GetListAsync();
        Task<List<T>> FindAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T req);
        Task DeleteAsync(T req);
        Task UpdateAsync(T req);
        Task DeleteByIdAsync(int Id);
        IQueryable<T> GetAll(bool notTrack = false);
    }
}
