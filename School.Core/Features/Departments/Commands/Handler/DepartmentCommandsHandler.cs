using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Core.Features.Departments.Commands.Models;
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

namespace School.Core.Features.Departments.Commands.Handler
{
	public class DepartmentCommandsHandler : ResponseHandler, IRequestHandler<AddDepartmentCommand, ResponseRepository<string>>
															, IRequestHandler<EditDepartmentCommand, ResponseRepository<string>>

	{
		private readonly IDepartmentService _departmentService;
		private readonly IMapper _mapper;

		public DepartmentCommandsHandler(IStringLocalizer<LocalizationResource> localizer, IDepartmentService departmentService, IMapper mapper) : base(localizer)
		{
			_departmentService = departmentService;
			_mapper = mapper;
		}

		public async Task<ResponseRepository<string>> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
		{
			var departMapper = _mapper.Map<Department>(request);
			var res = await _departmentService.addDepartment(departMapper);
			if (res == "Exist")
				return AlreadyExist<string>();
			else if (res == "Success")
				return Created("");
			return BadRequest<string>();
		}

		public async Task<ResponseRepository<string>> Handle(EditDepartmentCommand request, CancellationToken cancellationToken)
		{
			var department = await _departmentService.getDepartmentById(request.Id);
			if (department == null)
				return NotFound<string>();
			var departmentMapper = _mapper.Map<Department>(request);
			var res = await _departmentService.editDepartment(departmentMapper);
			if (res == "Success")
				return Success("");
			else if (res == "Exist")
				return AlreadyExist<string>();
			return BadRequest<string>();
		}
	}
}
