using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Repositories;
using School.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Service.UnitOfWork
{
	public class DepartmentService : IDepartmentService
	{
		private readonly IDepartmentRepository _departmentRepository;

		public DepartmentService(IDepartmentRepository departmentRepository)
        {
			_departmentRepository = departmentRepository;
		}
        public async Task<Department> getDepartmentById(int id)
		{
			var depart = await _departmentRepository.GetTableNoTracking().Where(x => x.DID.Equals(id))
												.Include(x => x.DepartmentSubjects)
												.Include(x => x.Students).FirstOrDefaultAsync();
			return depart;
		}
	}
}
