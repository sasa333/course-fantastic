using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseFantastic.DataAccess.Models
{
    public class Person
    {
        public String FirstName { get; set; }
        public String Surname { get; set; }
        public int Id { get; set; }

        public String Identity { get; set; }

        public DateTime DoB { get; set; }

        public String Email { get; set; }


    }
}
