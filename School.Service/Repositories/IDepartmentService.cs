using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service.Repositories
{
	public interface IDepartmentService
	{
		public Task<Department> getDepartmentById(int id); 
		public Task<List<Department>> getDepartmentList(); 
		public Task<string> addDepartment(Department department); 
		public Task<string> editDepartment(Department department); 
	}
}