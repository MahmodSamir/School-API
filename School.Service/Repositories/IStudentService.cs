using School.Data.Entities;

namespace School.Service.Repositories
{
	public interface IStudentService
	{
		public Task<List<Student>> GetAllStudentsAsync(); 
		public Task<Student> GetStudentByIdAsync(int id); 
	}
}
