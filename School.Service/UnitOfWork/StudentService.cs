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
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _studentRepository;

		public StudentService(IStudentRepository studentRepository)
        {
			_studentRepository = studentRepository;
		}
        public async Task<List<Student>> GetAllyStudentsAsync()
		{
			return await _studentRepository.GetAllStudentsAsync();
		}
	}
}
