using MediatR;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Commands.Models
{
	public class DeleteStudentCommand : IRequest<ResponseRepository<string>>
	{
		public int Id { get; set; }
		public DeleteStudentCommand (int id)
		{ this.Id = id; }
	}
}
