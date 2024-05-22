using AutoMapper;
using School.Core.Features.Departments.Responses;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.Departments
{
    public partial class DepartmentProfile
	{
		public void GetDepartmentByIdMapping()
		{
			CreateMap<Department, GetDepartmentByIdQueryResponse>()
				.ForMember(d => d.name, o => o.MapFrom(s => s.DName))
				.ForMember(d => d.Id, o => o.MapFrom(s => s.DID))
				.ForMember(d => d.studentList, o => o.MapFrom(s => s.Students))
				.ForMember(d => d.subjectList, o => o.MapFrom(s => s.DepartmentSubjects));

			CreateMap<DepartmentSubject, SubjectResponse>()
				.ForMember(d => d.Id, o => o.MapFrom(s => s.SubID))
				.ForMember(d => d.name, o => o.MapFrom(s => s.Subject.SubjectName));

			CreateMap<Student, StudentResponse>()
				.ForMember(d => d.Id, o => o.MapFrom(s => s.StudID))
				.ForMember(d => d.name, o => o.MapFrom(s => s.Name));
		}
	}
}