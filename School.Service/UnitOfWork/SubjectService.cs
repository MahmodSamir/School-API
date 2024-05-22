using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Data.MetaData;
using School.Infrastructure.Repositories;
using School.Infrastructure.UnitOfWork;
using School.Service.Repositories;

namespace School.Service.UnitOfWork
{
	public class SubjectService : ISubjectService
	{
		private readonly ISubjectRepository _subjectRepository;

		public SubjectService(ISubjectRepository subjectRepository)
        {
			_subjectRepository = subjectRepository;
		}
        public async Task<List<Subject>> GetAllSubjectAsync()
		{
			return await _subjectRepository.GetAllSubjectsAsync();
		}
	}
}