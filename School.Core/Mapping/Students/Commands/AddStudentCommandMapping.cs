using School.Core.Features.Students.Commands.Models;
using School.Core.Features.Students.Responses;
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
		public void AddStudentMapping()
		{
			CreateMap<AddStudentCommand, Student>().ForMember(d => d.DID,
					opt =>
					opt.MapFrom(s => s.DepartmentID));
		}
	}
}
