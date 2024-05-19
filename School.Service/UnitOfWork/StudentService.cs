using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.MetaData;
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
		
		public async Task<Student> GetStudentByIdWithoutDepartmentAsync(int id)
		{
			var student = _studentRepository.GetTableNoTracking()
				.Where(x => x.StudID.Equals(id))
				.FirstOrDefault();
			return student;
		}
		public async Task<string> AddStudent(Student student)
		{
			var exist = _studentRepository.GetTableNoTracking().Where(x=> x.Name == student.Name).FirstOrDefault();
			if (exist != null)
				return "Exist";
			await _studentRepository.AddAsync(student);
			return "Success";
		}
		public async Task<string> EditStudent(Student student)
		{
			var exist = _studentRepository.GetTableNoTracking().Where(x => x.Name == student.Name & !x.StudID.Equals(student.StudID)).FirstOrDefault();
			if (exist != null)
				return "Exist";
			await _studentRepository.UpdateAsync(student);
			return "Success";
		}
		public async Task<string> DeleteStudent(Student student)
		{
			await _studentRepository.DeleteAsync(student);
			return "Success";
		}

		public IQueryable<Student> GetStudentsPaginated()
		{
			return _studentRepository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
		}

		public IQueryable<Student> GetStudentsSearchedOrderedPaginated(string search, StudentOrderEnum orderBy)
		{
			var query =  _studentRepository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
			if(search != null)
				query = query.Where(predicate: x => x.Name.Contains(search) || x.Department.DName.Contains(search));
			switch(orderBy)
			{
				case StudentOrderEnum.StudID:
					query = query.OrderBy(x=>x.StudID); 
					break;
				case StudentOrderEnum.Name:
					query = query.OrderBy(x => x.Name);
					break;
				case StudentOrderEnum.DepartmentName:
					query = query.OrderBy(x => x.Department.DName);
					break;
				default: 
					query = query.OrderBy(x => x.StudID);
					break;
			}
			return query;
		}
	}
}