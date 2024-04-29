using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
	public class DepartmentSubject
	{
		[Key]
		public int DeptSubID { get; set; }
		public int DID { get; set; }
		public int SubID { get; set; }

		[ForeignKey("DID")]
		public Department Department { get; set; }

		[ForeignKey("SubID")]
		public Subject Subject { get; set; }
	}
}
