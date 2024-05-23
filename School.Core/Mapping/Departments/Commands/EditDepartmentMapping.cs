using School.Core.Features.Departments.Commands.Models;
using School.Core.Features.Students.Commands.Models;
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
		public void EditDepartmentMapping() 
		{
			CreateMap<EditDepartmentCommand, Department>().ForMember(d => d.DID, opt => opt.MapFrom(s => s.Id))
				.ForMember(d => d.DName,opt =>opt.MapFrom(s => s.Dname));
		}
	}
}
