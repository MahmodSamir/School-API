using School.Data.Entities;
using School.Infrastructure.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
	public interface ISubjectRepository : IGenericRepositoryAsync<Subject>
	{
		public Task<List<Subject>> GetAllSubjectsAsync();
	}
}
