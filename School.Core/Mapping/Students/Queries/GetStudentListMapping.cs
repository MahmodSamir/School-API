using School.Core.Features.Students.Responses;
using School.Data.Entities;

namespace School.Core.Mapping.Students
{
	public partial class StudentProfile
	{
		public void GetStudentListMapping()
		{
			CreateMap<Student, GetStudentListResponse>().ForMember(d => d.DepartmentName,
					opt =>
					opt.MapFrom(s => s.Department.DName));
		}
	}
}
