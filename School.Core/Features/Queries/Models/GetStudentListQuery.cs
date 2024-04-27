using MediatR;
using School.Core.Features.Queries.Responses;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Queries.Models
{
    public class GetStudentListQuery : IRequest<List<GetStudentListResponse>>
    {

    }
}
