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

		public async Task<string> addSubject(Subject subject)
		{
			var exist = _subjectRepository.GetTableNoTracking().Where(x => x.SubjectName == subject.SubjectName).FirstOrDefault();
			if (exist != null)
				return "Exist";
			await _subjectRepository.AddAsync(subject);
			return "Success";
		}

		public async Task<string> editSubject(Subject subject)
		{
			var exist = _subjectRepository.GetTableNoTracking().Where(x => x.SubjectName == subject.SubjectName & !x.SubID.Equals(subject.SubID)).FirstOrDefault();
			if (exist != null)
				return "Exist";
			await _subjectRepository.UpdateAsync(subject);
			return "Success";
		}

		public async Task<List<Subject>> GetAllSubjectAsync()
		{
			return await _subjectRepository.GetAllSubjectsAsync();
		}

		public async Task<Subject> getSubjectById(int id)
		{
			return _subjectRepository.GetTableNoTracking().Where(x=> x.SubID.Equals(id)).FirstOrDefault();
		}
	}
}