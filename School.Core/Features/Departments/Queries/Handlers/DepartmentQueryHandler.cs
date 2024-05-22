using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Core.Features.Departments.Queries.Models;
using School.Core.Features.Departments.Responses;
using School.Core.Response;
using School.Core.SharedResource;
using School.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Departments.Queries.Handlers
{
    internal class DepartmentQueryHandler : ResponseHandler, IRequestHandler<GetDepartmentByIdQuery, ResponseRepository<GetDepartmentByIdQueryResponse>>
	{
		private readonly IStringLocalizer<LocalizationResource> _localizer;
		private readonly IDepartmentService _departmentService;
		private readonly IMapper _mapper;

		public DepartmentQueryHandler(IStringLocalizer<LocalizationResource> localizer, IDepartmentService departmentService, IMapper mapper) : base(localizer)
        {
			_localizer = localizer;
			_departmentService = departmentService;
			_mapper = mapper;
		}
        public async Task<ResponseRepository<GetDepartmentByIdQueryResponse>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
		{
			var depart = await _departmentService.getDepartmentById(request.Id);
			if (depart == null)
				return NotFound<GetDepartmentByIdQueryResponse>();
			var departMapper = _mapper.Map<GetDepartmentByIdQueryResponse>(depart);
			return Success(departMapper);
		}
	}
}
