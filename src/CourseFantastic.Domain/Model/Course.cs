using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseFantastic.Domain.Model
{
    public class Course
    {




        private Qualification _qualification;

        public Qualification Qualification
        {
            get { return _qualification; }
            set { _qualification = value; }
        }

        private string _courseID;

        public string CourseID
        {
            get { return _courseID; }
            set { _courseID = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Course(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Course(string description, Qualification qualification)
            : this(qualification.ToString(), description)
        {
            Qualification = qualification;

        }

    }

}
