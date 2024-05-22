using School.Core.Features.Students.Responses;
using School.Core.Features.Subjects.Responses;
using School.Data.Entities;

namespace School.Core.Mapping.Subjects
{
	public partial class SubjectProfile
	{
		public void GetSubjectListMapping()
		{
			CreateMap<Subject, GetSubjectListResponse>().ForMember(d => d.SubID,
					opt =>
					opt.MapFrom(s => s.SubID)).ForMember(d => d.Name, opt => opt.MapFrom(s => s.SubjectName));
		}
	}
}
