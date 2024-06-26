﻿using MediatR;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Commands.Models
{
	public class AddStudentCommand : IRequest<ResponseRepository<string>>
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Address { get; set; }
		public string Phone { get; set; }
		public int DepartmentID { get; set; }
	}
}
