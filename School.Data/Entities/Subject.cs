using System.ComponentModel.DataAnnotations;

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
		public ICollection<StudentSubject> StudentsSubjects { get; set; }
		public ICollection<DepartmentSubject> DepartmentsSubjects { get; set; }
	}
}
