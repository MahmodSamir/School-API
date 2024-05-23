using School.Core.Features.Departments.Queries.Models;
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
		public void GetDepartmentListMapping()
		{
			CreateMap<Department, GetDepartmentListQueryResponse>()
				.ForMember(d => d.Id, o => o.MapFrom(s => s.DID))
				.ForMember(d => d.name, o => o.MapFrom(s => s.DName));
		}
	}
}
