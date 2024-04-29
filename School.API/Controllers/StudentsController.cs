using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Student.Queries.Models;
using School.Data.MetaData;

namespace School.API.Controllers
{
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public StudentsController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpGet(Router.StudentRouter.List)]
		public async Task<IActionResult> GettAllStudents()
		{
			var res = await _mediator.Send(new GetStudentListQuery());
			return Ok(res);
		}
		[HttpGet(Router.StudentRouter.GetByID)]
		public async Task<IActionResult> GetStudentByID([FromRoute] int id)
		{
			var res = await _mediator.Send(new GetStudentByIdQuery(id));
			return Ok(res);
		}
	}
}
