﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Core.Features.Subjects.Queries.Models;
using School.Core.Features.Subjects.Responses;
using School.Core.Response;
using School.Core.SharedResource;
using School.Core.Wrapper;
using School.Data.Entities;
using School.Service.Repositories;
using System.Linq.Expressions;

namespace School.Core.Features.Subjects.Queries.Handlers
{
	public class SubjectHandler : ResponseHandler,
                                    IRequestHandler<GetSubjectListQuery, ResponseRepository<List<GetSubjectListResponse>>>
    {
        private readonly ISubjectService _subjectService;
        private readonly IMapper _mapper;
		private readonly IStringLocalizer<LocalizationResource> _localizer;

        public SubjectHandler(ISubjectService subjectService, IMapper mapper, IStringLocalizer<LocalizationResource>  localizer) : base(localizer)
        {
			_subjectService = subjectService;
            _mapper = mapper;
			_localizer = localizer;
		}
        public async Task<ResponseRepository<List<GetSubjectListResponse>>> Handle(GetSubjectListQuery request, CancellationToken cancellationToken)
        {
            var subjectslist = await _subjectService.GetAllSubjectAsync();
            var res = _mapper.Map<List<GetSubjectListResponse>>(subjectslist);
            return Success(res);
        }
	}
}
