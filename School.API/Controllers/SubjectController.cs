using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Subjects.Commands.Models;
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
		public async Task<IActionResult> GetAllSubjects()
		{
			var res = await _mediator.Send(new GetSubjectListQuery());
			return CustomResult(res);
		}
		[HttpGet(Router.SubjectRouter.GetByID)]
		public async Task<IActionResult> GetSubjectById([FromRoute] int id)
		{
			var res = await _mediator.Send(new GetSubjectByIdQuery(id));
			return CustomResult(res);
		}
		[HttpPost(Router.SubjectRouter.Create)]
		public async Task<IActionResult> AddSubject([FromBody] AddSubjectCommand subject)
		{
			var res = await _mediator.Send(subject);
			return CustomResult(res);
		}
		[HttpPut(Router.SubjectRouter.Edit)]
		public async Task<IActionResult> EditSubject([FromBody] EditSubjectCommand subject)
		{
			var res = await _mediator.Send(subject);
			return CustomResult(res);
		}

	}
}
