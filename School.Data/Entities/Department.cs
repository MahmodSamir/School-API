using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
	public class Department
	{
		public Department()
		{
			Students = new HashSet<Student>();
			DepartmentSubjects = new HashSet<DepartmentSubject>();
		}
		[Key]
		public int DID { get; set; }
		[StringLength(500)]
		public string DName { get; set; }
		public ICollection<Student> Students { get; set; }
		public ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
	}
}
