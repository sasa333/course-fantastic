using System;
namespace CourseFantastic.Domain.Model {
	public class Subject {
		private string _name;
		private string _description;
		private string _subjectId;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string SubjectId
        {
            get
            {
                return _subjectId;
            }

            set
            {
                _subjectId = value;
            }
        }

        public Subject(string name, string desc) {
            Name = name;
            Description = desc;
		}


	}

}
