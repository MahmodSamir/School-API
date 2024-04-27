using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Repositories
{
	public interface IStudentRepository
	{
		public Task<List<Student>> GetAllStudentsAsync();
	}
}
