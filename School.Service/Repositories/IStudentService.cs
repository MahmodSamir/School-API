using School.Data.Entities;

namespace School.Service.Repositories
{
	public interface IStudentService
	{
		public Task<List<Student>> GetAllStudentsAsync(); 
		public Task<Student> GetStudentByIdAsync(int id); 
		public Task<Student> GetStudentByIdWithoutDepartmentAsync(int id); 
		public Task<string> AddStudent(Student student); 
		public Task<string> EditStudent(Student student); 
		public Task<string> DeleteStudent(Student student); 
	}
}
