using AutoMapper;
using School.Core.Features.Departments.Commands.Models;
using School.Core.Features.Departments.Responses;
using School.Core.Response;
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
		public void AddDepartmentMapping()
		{
			CreateMap<AddDepartmentCommand, Department>()
				.ForMember(d => d.DName, o => o.MapFrom(s => s.DName));
		}
	}
}