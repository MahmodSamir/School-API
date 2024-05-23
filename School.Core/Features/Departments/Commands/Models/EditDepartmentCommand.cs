using MediatR;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Departments.Commands.Models
{
	public class EditDepartmentCommand : IRequest<ResponseRepository<string>>
	{
        public int Id{ get; set; }
		public string Dname { get; set; }
	}
}
