using School.Core.Features.Student.Responses;
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
