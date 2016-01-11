using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public class Student : Learner  {
		public Dictionary<string, List<Attendance>> attendance;
		public List<Enrolment> enrolments;
		public Boolean active;
		public string studentID;

		public Student(Person person, string studentID, Enrolment e) {
			throw new System.Exception("Not implemented");
		}
		public Student(Person person, string studentID) {
			throw new System.Exception("Not implemented");
		}
		public List<Enrolment> GetActiveEnrolments()
        {
			throw new System.Exception("Not implemented");
		}
		public Enrolment Enrol(string callOccCode) {
			throw new System.Exception("Not implemented");
		}

		private Person _person;

        public Person Person
        {
            get
            {
                return _person;
            }

            set
            {
                _person = value;
            }
        }
    }

}
