using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Generics;
using School.Infrastructure.Models;
using School.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.UnitOfWork
{
	public class SubjectRepository : GenericRepositoryAsync<Subject>, ISubjectRepository
	{
		private readonly ApplicationDBContext _dbContext;

		public SubjectRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
			_dbContext = dbContext;
		}

		public async Task<List<Subject>> GetAllSubjectsAsync()
		{
			return await _dbContext.Subject.ToListAsync();
		}
	}
}
