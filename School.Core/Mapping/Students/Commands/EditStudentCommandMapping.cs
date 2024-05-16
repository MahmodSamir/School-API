using AutoMapper;
using School.Core.Features.Students.Commands.Models;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.Students
{
	public partial class StudentProfile : Profile
	{
		public void EditStudentMapping()
		{
			CreateMap<EditStudentCommand, Student>().ForMember(d => d.DID,
					opt =>
					opt.MapFrom(s => s.DepartmentID)).ForMember(d => d.StudID,
					opt =>
					opt.MapFrom(s => s.Id));
		}

	}
}
