﻿using MediatR;
using School.Core.Features.Students.Responses;
using School.Core.Response;

namespace School.Core.Features.Students.Queries.Models
{
	public class GetStudentByIdQuery : IRequest<ResponseRepository<GetSingleStudentResponse>>
    {
        public int id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
