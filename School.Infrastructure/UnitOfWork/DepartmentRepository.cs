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
	public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
	{
		private readonly ApplicationDBContext _dbContext;

		public DepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
			_dbContext = dbContext;
		}
    }
}
