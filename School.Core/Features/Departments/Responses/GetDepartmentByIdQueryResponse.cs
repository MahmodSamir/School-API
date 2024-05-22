using School.Core.Features.Students.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Departments.Responses
{
    public class GetDepartmentByIdQueryResponse
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<StudentResponse>? studentList { get; set; }
        public List<SubjectResponse>? subjectList { get; set; }
    }
    public class StudentResponse
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
    public class SubjectResponse
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
