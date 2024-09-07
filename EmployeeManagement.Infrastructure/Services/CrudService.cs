
using EmployeeManagement.Domain.Entities;
using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EmployeeManagment.Application.Interfaces;

namespace Services
{
    public class CrudService<T> : IService<T> where T : class, IEntity, new()
    {
        public readonly IEntityRepository<T> _crudRepository;
        public CrudService(IEntityRepository<T> crudRepository)
        {
            _crudRepository = crudRepository;
        }
        public async Task AddAsync(T req)
        {
           await _crudRepository.AddAsync(req);
        }

        public async Task DeleteAsync(T req)
        {
           await _crudRepository.DeleteAsync(req);
        }

        public async Task DeleteByIdAsync(int Id)
        {
            await _crudRepository.DeleteAsync(x => x.Id == Id);
        }

        public async Task<T> FindByIdAsync(int Id)
        {
            return await _crudRepository.GetAsync(x => x.Id == Id);
        }

        public async Task<List<T>> GetListAsync()
        {
            return (await _crudRepository.GetListAsync()).ToList();
        }
        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> filter)
        {
            return (await _crudRepository.FindAsync(filter)).ToList();
        }

        public async Task UpdateAsync(T req)
        {
           await _crudRepository.UpdateAsync(req);
        }

        public IQueryable<T> GetAll(bool notTrack = false)
        {
            return  _crudRepository.GetAll(notTrack);
        }
    }
}
