using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Generics;
using School.Infrastructure.Models;
using School.Infrastructure.Repositories;

namespace School.Infrastructure.UnitOfWork
{
	public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
	{
		private readonly ApplicationDBContext _dbContext;

		public StudentRepository(ApplicationDBContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}
        public async Task<List<Student>> GetAllStudentsAsync()
		{
			return await _dbContext.Student.Include(x=>x.Department).ToListAsync();
		}
	}
}
