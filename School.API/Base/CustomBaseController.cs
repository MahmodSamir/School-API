using Azure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Core.Response;
using System.Net;

namespace School.API.Base
{
	//[Route("api/[controller]")]
	[ApiController]
	public class CustomBaseController : ControllerBase
	{
		private IMediator _mediator;
        public CustomBaseController(IMediator mediator)
        {
			_mediator = mediator;
        }
        public ObjectResult CustomResult<T>(ResponseRepository<T> response)
		{
			switch (response.StatusCode)
			{
				case HttpStatusCode.OK:
					return new OkObjectResult(response);
				case HttpStatusCode.Created:
					return new CreatedResult(string.Empty, response);
				case HttpStatusCode.Unauthorized:
					return new UnauthorizedObjectResult(response);
				case HttpStatusCode.BadRequest:
					return new BadRequestObjectResult(response);
				case HttpStatusCode.NotFound:
					return new NotFoundObjectResult(response);
				case HttpStatusCode.Accepted:
					return new AcceptedResult(string.Empty, response);
				case HttpStatusCode.UnprocessableEntity:
					return new UnprocessableEntityObjectResult(response);
				default:
					return new BadRequestObjectResult(response);
			}
		}
	}
}
