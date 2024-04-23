using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
	public class Subject
	{
		public Subject()
		{
			StudentsSubjects = new HashSet<StudentSubject>();
			DepartmentsSubjects = new HashSet<DepartmentSubject>();
		}
		[Key]
		public int SubID { get; set; }
		[StringLength(50)]
		public string SubjectName { get; set; }
		public DateTime Period { get; set; }
		public ICollection<StudentSubject> StudentsSubjects { get; set; }
		public ICollection<DepartmentSubject> DepartmentsSubjects { get; set; }
	}
}
