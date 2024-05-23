using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Repositories;
using School.Infrastructure.UnitOfWork;
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

		public async Task<string> addDepartment(Department department)
		{
			var res = _departmentRepository.GetTableNoTracking().Where(x=> x.DName == department.DName).FirstOrDefault();
			if (res != null)
				return "Exist";
			await _departmentRepository.AddAsync(department);
			return "Success";
		}

		public async Task<string> editDepartment(Department department)
		{
			var exist = _departmentRepository.GetTableNoTracking().Where(x => x.DName == department.DName &! x.DID.Equals(department.DID)).FirstOrDefault();
			if (exist != null)
				return "Exist";
			await _departmentRepository.UpdateAsync(department);
			return "Success";
		}

		public async Task<Department> getDepartmentById(int id)
		{
			var depart = await _departmentRepository.GetTableNoTracking().Where(x => x.DID.Equals(id))
												.Include(x => x.DepartmentSubjects)
												.Include(x => x.Students).FirstOrDefaultAsync();
			return depart;
		}

		public async Task<List<Department>> getDepartmentList()
		{
			var departs = await _departmentRepository.GetTableNoTracking().ToListAsync();
			return departs;
		}
	}
}
