using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Subjects.Queries.Models;
using School.Data.MetaData;

namespace School.API.Controllers
{
	public class SubjectController : CustomBaseController
	{
		private readonly IMediator _mediator;
		public SubjectController(IMediator mediator) : base(mediator)
		{
			_mediator = mediator;
		}

		[HttpGet(Router.SubjectRouter.List)]
		public async Task<IActionResult> GettAllSubjects()
		{
			var res = await _mediator.Send(new GetSubjectListQuery());
			return CustomResult(res);
		}

	}
}
