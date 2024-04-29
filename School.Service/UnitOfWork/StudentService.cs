using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Repositories;
using School.Infrastructure.UnitOfWork;
using School.Service.Repositories;

namespace School.Service.UnitOfWork
{
	public class StudentService : IStudentService
	{
		private readonly IStudentRepository _studentRepository;

		public StudentService(IStudentRepository studentRepository)
        {
			_studentRepository = studentRepository;
		}
        public async Task<List<Student>> GetAllStudentsAsync()
		{
			return await _studentRepository.GetAllStudentsAsync();
		}
		public async Task<Student> GetStudentByIdAsync(int id)
		{
			var student = _studentRepository.GetTableNoTracking()
				.Include(x => x.Department)
				.Where(x => x.StudID.Equals(id))
				.FirstOrDefault();
			return student;
		}
	}
}
