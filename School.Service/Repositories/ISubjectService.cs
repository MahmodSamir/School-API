using School.Data.Entities;
using School.Data.MetaData;

namespace School.Service.Repositories
{
	public interface ISubjectService
	{
		public Task<List<Subject>> GetAllSubjectAsync(); 
		public Task<Subject> getSubjectById(int id); 
		public Task<string> editSubject(Subject subject); 
		public Task<string> addSubject(Subject subject); 
	}
}
