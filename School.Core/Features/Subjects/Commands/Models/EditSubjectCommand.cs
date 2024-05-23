using MediatR;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Subjects.Commands.Models
{
	public class EditSubjectCommand : IRequest<ResponseRepository<string>>
	{
		public int Id { get; set; }

		public string name { get; set; }
    }
}
