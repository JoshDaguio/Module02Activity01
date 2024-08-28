using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Activity01.Model
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullNames => $"{FirstName} {LastName}";

    }
}
