using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.MetaData
{
	public static class Router
	{
		public const string root = "School";
        public class StudentRouter()
        {
            public const string prefix = root+ "/Student";
            public const string List = prefix+ "/List";
            public const string GetByID = prefix+ "/{id}";
            public const string Create = prefix+ "/Create";
            public const string Edit = prefix+ "/Edit";
            public const string Delete = prefix+ "/{id}";
		}
    }
}
