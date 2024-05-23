using AutoMapper;
using Azure.Core;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Core.Features.Subjects.Commands.Models;
using School.Core.Response;
using School.Core.SharedResource;
using School.Data.Entities;
using School.Service.Repositories;
using School.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Subjects.Commands.Handler
{
	public class SubjectCommandsHandler : ResponseHandler
														, IRequestHandler<EditSubjectCommand, ResponseRepository<string>>
														, IRequestHandler<AddSubjectCommand, ResponseRepository<string>>
	{
		private readonly ISubjectService _subjectService;
		private readonly IMapper _mapper;

		public SubjectCommandsHandler(IStringLocalizer<LocalizationResource> localizer, ISubjectService subjectService, IMapper mapper) : base(localizer)
		{
			_subjectService = subjectService;
			_mapper = mapper;
		}

		public async Task<ResponseRepository<string>> Handle(EditSubjectCommand request, CancellationToken cancellationToken)
		{
			var subject = await _subjectService.getSubjectById(request.Id);
			if (subject == null)
				return NotFound<string>();
			var subjectMapper = _mapper.Map<Subject>(request);
			var res = await _subjectService.editSubject(subjectMapper);
			if (res == "Success")
				return Success("");
			else if (res == "Exist")
				return AlreadyExist<string>();
			return BadRequest<string>();
		}

		public async Task<ResponseRepository<string>> Handle(AddSubjectCommand request, CancellationToken cancellationToken)
		{
			var subjectMapper = _mapper.Map<Subject>(request);
			var subject = await _subjectService.addSubject(subjectMapper);
			if (subject == "Exist")
				return AlreadyExist<string>();
			else if (subject == "Success")
				return Success("");
			return BadRequest<string>();
		}
	}
}
