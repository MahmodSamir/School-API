using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Models;
using School.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.UnitOfWork
{
	public class StudentRepository : IStudentRepository
	{
		private readonly ApplicationDBContext _dbContext;

		public StudentRepository(ApplicationDBContext dbContext)
        {
			_dbContext = dbContext;
		}
        public async Task<List<Student>> GetAllStudentsAsync()
		{
			return await _dbContext.Student.Include(x=>x.Department).ToListAsync();
		}
	}
}
