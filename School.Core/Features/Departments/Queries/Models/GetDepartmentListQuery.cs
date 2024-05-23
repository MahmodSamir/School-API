using MediatR;
using School.Core.Features.Departments.Responses;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Departments.Queries.Models
{
	public class GetDepartmentListQuery : IRequest<ResponseRepository<List<GetDepartmentListQueryResponse>>>
	{
	}
}
