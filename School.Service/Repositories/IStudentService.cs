using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service.Repositories
{
	public interface IStudentService
	{
		public Task<List<Student>> GetAllyStudentsAsync(); 
	}
}
