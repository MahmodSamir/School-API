using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Core.Features.Departments.Commands.Models;
using School.Core.Features.Departments.Queries.Models;
using School.Core.Features.Students.Queries.Models;
using School.Data.Entities;
using School.Data.MetaData;

namespace School.API.Controllers
{
	public class DepartmentController : CustomBaseController
	{
		private readonly IMediator _mediator;

		public DepartmentController(IMediator mediator) : base(mediator)
		{
			_mediator = mediator;
		}

		[HttpGet(Router.DepartmentRouter.GetByID)]
		public async Task<IActionResult> GetDepartmentByID([FromRoute] int id)
		{
			var res = await _mediator.Send(new GetDepartmentByIdQuery(id));
			return CustomResult(res);
		}
		[HttpGet(Router.DepartmentRouter.List)]
		public async Task<IActionResult> GetDepartmentList()
		{
			var res = await _mediator.Send(new GetDepartmentListQuery());
			return CustomResult(res);
		}
		[HttpPost(Router.DepartmentRouter.Create)]
		public async Task<IActionResult> AddDepartment([FromBody] AddDepartmentCommand department)
		{
			var res = await _mediator.Send(department);
			return CustomResult(res);
		}
		[HttpPut(Router.DepartmentRouter.Edit)]
		public async Task<IActionResult> EditDepartment([FromBody] EditDepartmentCommand deaprtment)
		{
			var res = await _mediator.Send(deaprtment);
			return CustomResult(res);
		}
	}
}
