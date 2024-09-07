using Employee.Domain.Entities;
using EmployeeManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    {
        private readonly EmployeeManagmentDbContext _context;
        protected readonly DbSet<TEntity> _entity;
        public EfEntityRepositoryBase(EmployeeManagmentDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {

            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(TEntity entity)
        {

            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> filter)
        {
            var entity= await _entity.SingleOrDefaultAsync(filter);
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {

            return await _entity.SingleOrDefaultAsync(filter);

        }


        public async Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null
                ? await _entity.ToListAsync()
                : await _entity.Where(filter).ToListAsync();

        }
        public async Task<IList<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null
                ? await _entity.ToListAsync()
                : await _entity.Where(filter).ToListAsync();

        }

        public async Task UpdateAsync(TEntity entity)
        {

            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public IQueryable<TEntity> GetAll(bool notTrack = false)
        {
            DbSet<TEntity> dbSet = _entity;
            return dbSet;
        }

    }
}
