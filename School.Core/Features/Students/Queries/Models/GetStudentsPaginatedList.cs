using MediatR;
using School.Core.Features.Students.Responses;
using School.Core.Wrapper;
using School.Data.MetaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Queries.Models
{
	public class GetStudentsPaginatedList : IRequest<PaginatedResult<GetStudentsPaginatedListResponse>>
	{
        public int pageNumber{ get; set; }
		public int pageSize { get; set; }
        public StudentOrderEnum orderBy{ get; set; }
        public string? search{ get; set; }
	}
}
