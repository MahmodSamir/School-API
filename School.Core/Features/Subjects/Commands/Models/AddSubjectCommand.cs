using MediatR;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Subjects.Commands.Models
{
	public class AddSubjectCommand : IRequest<ResponseRepository<string>>
	{
		[Required]
		public string name { get; set; }
	}
}
