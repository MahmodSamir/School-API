using MediatR;
using School.Core.Features.Subjects.Responses;
using School.Core.Response;

namespace School.Core.Features.Subjects.Queries.Models
{
    public class GetSubjectListQuery : IRequest<ResponseRepository<List<GetSubjectListResponse>>>
    {

    }
}
