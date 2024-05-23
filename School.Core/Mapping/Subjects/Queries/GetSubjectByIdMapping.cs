using School.Core.Features.Subjects.Queries.Response;
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
		public void GetSubjectByIdMapping()
		{
			CreateMap<Subject, GetSubjectByIdQueryResponse>()
				.ForMember(d => d.SubID, o => o.MapFrom(s => s.SubID))
				.ForMember(d => d.Name, o => o.MapFrom(s => s.SubjectName));
		}
	}
}
