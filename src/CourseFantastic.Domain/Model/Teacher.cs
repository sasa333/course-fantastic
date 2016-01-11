using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {

    public class Teacher : Instructor  {
        private List<InstructorAssignment> assignments;
        private string employeeID;
        private string officeLocation;

        public Teacher(Person person, string employeeID) {
			throw new System.Exception("Not implemented");
		}
		public Teacher(Person person, string employeeID, List<InstructorAssignment> subjects) {
			throw new System.Exception("Not implemented");
		}
		public List<InstructorAssignment> FetchActiveAssignments() {
			throw new System.Exception("Not implemented");
		}
		public InstructorAssignment CreateAssignment(string employeeID, string subjectDeliveryID, InstructorAssignmentRole role) {
			throw new System.Exception("Not implemented");
		}

		private Person person;
		private System.Collections.Generic.List<InstructorAssignment> subjectAssignments;

        public List<InstructorAssignment> Assignments
        {
            get
            {
                return assignments;
            }

            set
            {
                assignments = value;
            }
        }

        public string EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public string OfficeLocation
        {
            get
            {
                return officeLocation;
            }

            set
            {
                officeLocation = value;
            }
        }
    }

}
