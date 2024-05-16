using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Students.Queries.Models;
using School.Data.MetaData;
using School.Core.Features.Students.Commands.Models;
using School.API.Base;
using Microsoft.AspNetCore.Components.Forms;
namespace School.API.Controllers
{
	[ApiController]
	public class StudentsController : CustomBaseController
	{
		private readonly IMediator _mediator;

		public StudentsController(IMediator mediator) : base(mediator)
		{
			_mediator = mediator;
		}

		[HttpGet(Router.StudentRouter.List)]
		public async Task<IActionResult> GettAllStudents()
		{
			var res = await _mediator.Send(new GetStudentListQuery());
			return CustomResult(res);
		}
		[HttpGet(Router.StudentRouter.GetByID)]
		public async Task<IActionResult> GetStudentByID([FromRoute] int id)
		{
			var res = await _mediator.Send(new GetStudentByIdQuery(id));
			return CustomResult(res);
		}
		[HttpPost(Router.StudentRouter.Create)]
		public async Task<IActionResult> AddStudent([FromBody] AddStudentCommand student)
		{
			var res = await _mediator.Send(student);
			return CustomResult(res);
		}
		[HttpPut(Router.StudentRouter.Edit)]
		public async Task<IActionResult> EditStudent([FromBody] EditStudentCommand student)
		{
			var res = await _mediator.Send(student);
			return CustomResult(res);
		}
		[HttpDelete(Router.StudentRouter.Delete)]
		public async Task<IActionResult> DeleteStudent([FromRoute] int id)
		{
			var res = await _mediator.Send(new DeleteStudentCommand(id));
			return CustomResult(res);
		}
	}
}
