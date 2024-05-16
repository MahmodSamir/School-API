using AutoMapper;
using MediatR;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Students.Responses;
using School.Core.Response;
using School.Service.Repositories;

namespace School.Core.Features.Students.Queries.Handlers
{
	public class StudentHandler : ResponseHandler,
                                    IRequestHandler<GetStudentListQuery, ResponseRepository<List<GetStudentListResponse>>>,
                                    IRequestHandler<GetStudentByIdQuery, ResponseRepository<GetSingleStudentResponse>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<ResponseRepository<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentslist = await _studentService.GetAllStudentsAsync();
            var res = _mapper.Map<List<GetStudentListResponse>>(studentslist);
            return Success(res);
        }
		public async Task<ResponseRepository<GetSingleStudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
		{
            var student = await _studentService.GetStudentByIdAsync(request.id);
            if(student == null)
                return NotFound<GetSingleStudentResponse>();
			var res = _mapper.Map<GetSingleStudentResponse>(student);
			return Success(res);
		}
	}
}
