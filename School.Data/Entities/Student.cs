using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
	public class Student
	{
		[Key]
		public int StudID { get; set; }
		[StringLength(50)]
		public string Name { get; set; }
		[StringLength(100)]
		public string Address { get; set; }
		[StringLength(11)]
		public string Phone { get; set; }
		public int? DID { get; set; }

		[ForeignKey("DID")]
		public Department Department { get; set; }
	}
}
