using School.Data.Entities;
using School.Data.MetaData;

namespace School.Service.Repositories
{
	public interface ISubjectService
	{
		public Task<List<Subject>> GetAllSubjectAsync(); 
	}
}
