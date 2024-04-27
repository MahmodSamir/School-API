using AutoMapper;
using MediatR;
using School.Core.Features.Queries.Models;
using School.Core.Features.Queries.Responses;
using School.Data.Entities;
using School.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Queries.Handlers
{
	public class StudentHandler : IRequestHandler<GetStudentListQuery, List<GetStudentListResponse>>
	{
		private readonly IStudentService _studentService;
		private readonly IMapper _mapper;

		public StudentHandler(IStudentService studentService, IMapper mapper)
        {
			_studentService = studentService;
			_mapper = mapper;
		}
        public async Task<List<GetStudentListResponse>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
		{
			var studentslist = await _studentService.GetAllyStudentsAsync();
			var res = _mapper.Map<List<GetStudentListResponse>>(studentslist);
			return res;
		}
	}
}
