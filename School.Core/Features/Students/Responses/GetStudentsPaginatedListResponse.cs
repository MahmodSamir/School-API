using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Students.Responses
{
	public class GetStudentsPaginatedListResponse
	{
		public int StudID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string? DepartmentName { get; set; }
		public GetStudentsPaginatedListResponse(int StudID, string Name, string Address, string DepartmentName)
		{
			this.StudID = StudID;
			this.Name = Name;
			this.Address = Address;
			this.DepartmentName = DepartmentName;
		}
	}
}
