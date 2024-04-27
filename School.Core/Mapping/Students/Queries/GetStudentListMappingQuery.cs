using School.Core.Features.Queries.Responses;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
