using School.Data.Entities;
using School.Infrastructure.Generics;

namespace School.Infrastructure.Repositories
{
	public interface IStudentRepository : IGenericRepositoryAsync<Student>
	{
		public Task<List<Student>> GetAllStudentsAsync();
	}
}
