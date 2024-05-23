using MediatR;
using School.Core.Features.Subjects.Queries.Response;
using School.Core.Response;
using School.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Subjects.Queries.Models
{
	public class GetSubjectByIdQuery : IRequest<ResponseRepository<GetSubjectByIdQueryResponse>>
	{
        public int Id { get; set; }

		public GetSubjectByIdQuery(int id)
		{
			Id = id;
		}
	}
}
