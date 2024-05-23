using MediatR;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Departments.Commands.Models
{
	public class AddDepartmentCommand : IRequest<ResponseRepository<string>>
	{
		[Required]
		public string DName { get; set; }
	}
}
