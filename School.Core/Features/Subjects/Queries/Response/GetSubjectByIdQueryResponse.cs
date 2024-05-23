using Microsoft.Extensions.Localization;
using School.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Subjects.Queries.Response
{
	public class GetSubjectByIdQueryResponse
	{
		public int SubID { get; set; }
		public string Name { get; set; }

	}
}
