using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Core.Features.Students.Queries.Models;
using School.Core.Features.Students.Responses;
using School.Core.Response;
using School.Core.SharedResource;
using School.Core.Wrapper;
using School.Data.Entities;
using School.Service.Repositories;
using System.Linq.Expressions;

namespace School.Core.Features.Students.Queries.Handlers
{
	public class StudentHandler : ResponseHandler,
                                    IRequestHandler<GetStudentListQuery, ResponseRepository<List<GetStudentListResponse>>>,
                                    IRequestHandler<GetStudentByIdQuery, ResponseRepository<GetSingleStudentResponse>>,
                                    IRequestHandler<GetStudentsPaginatedList, PaginatedResult<GetStudentsPaginatedListResponse>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
		private readonly IStringLocalizer<LocalizationResource> _localizer;

        public StudentHandler(IStudentService studentService, IMapper mapper, IStringLocalizer<LocalizationResource>  localizer) : base(localizer)
        {
            _studentService = studentService;
            _mapper = mapper;
			_localizer = localizer;
		}
        public async Task<ResponseRepository<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentslist = await _studentService.GetAllStudentsAsync();
            var res = _mapper.Map<List<GetStudentListResponse>>(studentslist);
            
            var result = Success(res);
            result.Meta = new { count = res.Count() };
            return result;
        }
		public async Task<ResponseRepository<GetSingleStudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
		{
            var student = await _studentService.GetStudentByIdAsync(request.id);
            if(student == null)
                return NotFound<GetSingleStudentResponse>();
			var res = _mapper.Map<GetSingleStudentResponse>(student);
			return Success(res);
		}

		public async Task<PaginatedResult<GetStudentsPaginatedListResponse>> Handle(GetStudentsPaginatedList request, CancellationToken cancellationToken)
		{
            Expression<Func<Student, GetStudentsPaginatedListResponse>> expression = e => new GetStudentsPaginatedListResponse(e.StudID, e.Name, e.Address, e.Department.DName);
            //var queryable = _studentService.GetStudentsPaginated();
            var queryable = _studentService.GetStudentsSearchedOrderedPaginated(request.search, request.orderBy);
            var paginated = await queryable.Select(expression).toPaginatedListAsync(request.pageNumber, request.pageSize);
            paginated.Meta = new { count = paginated.TotalCount };
            return paginated;
		}
	}
}
