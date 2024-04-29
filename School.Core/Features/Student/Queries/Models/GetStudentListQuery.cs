using MediatR;
using School.Core.Features.Student.Responses;
using School.Core.Response;

namespace School.Core.Features.Student.Queries.Models
{
	public class GetStudentListQuery : IRequest<ResponseRepository<List<GetStudentListResponse>>>
    {

    }
}
