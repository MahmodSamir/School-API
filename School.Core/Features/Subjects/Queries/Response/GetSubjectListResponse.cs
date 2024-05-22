using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Features.Subjects.Responses
{
    public class GetSubjectListResponse
    {
        public int SubID { get; set; }
        public string Name { get; set; }
    }
}
