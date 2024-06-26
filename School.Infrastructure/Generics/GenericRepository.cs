﻿using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Models;

namespace School.Infrastructure.Generics
{
	public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
	{
		protected readonly ApplicationDBContext _dbContext;

		public GenericRepositoryAsync(ApplicationDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
		public virtual async Task<T> GetByIdAsync(int id)
		{

			return await _dbContext.Set<T>().FindAsync(id);
		}
		public virtual async Task<T> AddAsync(T entity)
		{
			await _dbContext.Set<T>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();

			return entity;
		}
		public virtual async Task AddRangeAsync(ICollection<T> entities)
		{
			await _dbContext.Set<T>().AddRangeAsync(entities);
			await _dbContext.SaveChangesAsync();

		}
		public virtual async Task UpdateAsync(T entity)
		{
			_dbContext.Set<T>().Update(entity);
			await _dbContext.SaveChangesAsync();

		}
		public virtual async Task UpdateRangeAsync(ICollection<T> entities)
		{
			_dbContext.Set<T>().UpdateRange(entities);
			await _dbContext.SaveChangesAsync();
		}
		public virtual async Task DeleteAsync(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}
		public virtual async Task DeleteRangeAsync(ICollection<T> entities)
		{
			foreach (var entity in entities)
			{
				_dbContext.Entry(entity).State = EntityState.Deleted;
			}
			await _dbContext.SaveChangesAsync();
		}
		public IQueryable<T> GetTableNoTracking()
		{
			return _dbContext.Set<T>().AsNoTracking().AsQueryable();
		}
		public IQueryable<T> GetTableAsTracking()
		{
			return _dbContext.Set<T>().AsQueryable();

		}
	}
}
