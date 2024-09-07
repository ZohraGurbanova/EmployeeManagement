using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EntityFramework
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task<IList<T>> FindAsync(Expression<Func<T, bool>> filter = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll(bool notTrack = false);
    }
}
