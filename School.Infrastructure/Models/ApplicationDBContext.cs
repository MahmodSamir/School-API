using Microsoft.EntityFrameworkCore;
using School.Data.Entities;

namespace School.Infrastructure.Models
{
	public class ApplicationDBContext : DbContext
	{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { }
        public DbSet<Department> Department { get; set; }
		public DbSet<Subject> Subject { get; set; }
		public DbSet<Student> Student { get; set; }
		public DbSet<StudentSubject> StudentSubject { get; set; }
		public DbSet<DepartmentSubject> DepartmentSubject { get; set; }
	}
}
