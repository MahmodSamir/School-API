using MediatR;
using School.Core.Features.Students.Responses;
using School.Core.Response;

namespace School.Core.Features.Students.Queries.Models
{
	public class GetStudentListQuery : IRequest<ResponseRepository<List<GetStudentListResponse>>>
    {

    }
}
