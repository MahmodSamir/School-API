using AutoMapper;
using School.Core.Features.Subjects.Commands.Models;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Mapping.Subjects
{
	public partial class SubjectProfile
	{
		public void AddSubjectMapping()
		{
			CreateMap<AddSubjectCommand, Subject>()
				.ForMember(d => d.SubjectName, o => o.MapFrom(s => s.name));
		}
	}
}
