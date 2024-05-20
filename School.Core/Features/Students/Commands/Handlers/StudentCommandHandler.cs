using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Core.Features.Students.Commands.Models;
using School.Core.Response;
using School.Core.SharedResource;
using School.Data.Entities;
using School.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Commands.Handlers
{
	internal class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, ResponseRepository<string>>,
															IRequestHandler<EditStudentCommand, ResponseRepository<string>>,
															IRequestHandler<DeleteStudentCommand, ResponseRepository<string>>
	{
		private readonly IStudentService _studentService;
		private readonly IMapper _mapper;
		private readonly IStringLocalizer<LocalizationResource> _localizer;

		public StudentCommandHandler(IStudentService studentService, IMapper mapper, IStringLocalizer<LocalizationResource> localizer) : base(localizer)
		{
			_studentService = studentService;
			_mapper = mapper;
			_localizer = localizer;
		}
		public async Task<ResponseRepository<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
		{
			var studentMapper = _mapper.Map<Student>(request);
			var student = await _studentService.AddStudent(studentMapper);
			if (student == "Exist")
				return AlreadyExist<string>();
			else if (student == "Success")
				return Created("");
			return BadRequest<string>();
		}

		public async Task<ResponseRepository<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
		{
			var student = await _studentService.GetStudentByIdAsync(request.Id);
			if(student == null)
				return NotFound<string>();
			var studentMapper = _mapper.Map<Student>(request);
			var res = await _studentService.EditStudent(studentMapper);
			if (res == "Success")
				return Success("");
			else if (res == "Exist")
				return AlreadyExist<string>();
			return BadRequest<string>();
		}

		public async Task<ResponseRepository<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
		{
			var student = await _studentService.GetStudentByIdWithoutDepartmentAsync(request.Id);
			if (student == null)
				return NotFound<string>();
			var res = await _studentService.DeleteStudent(student);
			if (res == "Success")
				return Deleted<string>();
			return BadRequest<string>();
		}
	}
}
