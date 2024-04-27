using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Queries.Models;

namespace School.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public StudentsController(IMediator	mediator)
		{
			_mediator = mediator;
		}
		[HttpGet]
		public async Task<ActionResult> GettAllStudents()
		{
			var res = await _mediator.Send(new GetStudentListQuery());
			return Ok(res);
		}
	}
}
