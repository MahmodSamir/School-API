using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Core.Features.Departments.Queries.Models;
using School.Core.Features.Students.Queries.Models;
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

	}
}
