using System;
using System.Collections.Generic;
using  System.Linq;

namespace CourseFantastic.Domain.Model {

    public class Teacher : Instructor  {
        private List<InstructorAssignment> _assignments;
        private string _employeeId;
        private string _officeLocation;

        public Teacher(Person person, string employeeId, List<InstructorAssignment> subjectAssignments)
        {
            Person = person;
            EmployeeId = employeeId;
            Assignments = subjectAssignments;
        }
		public Teacher(Person person, string employeeId, List<InstructorAssignment> subjects, List<InstructorAssignment> subjectAssignments) :this(person, employeeId, subjectAssignments)
		{
		    Assignments = subjects;
		}

        

        public List<InstructorAssignment> FetchActiveAssignments()
		{
		    return Assignments.Where(a => a.Subject.CourseDetails.DeliveryPeriod.End <= DateTime.Now).ToList();
		}
		public InstructorAssignment CreateAssignment(Instructor teacher, SubjectDelivery subjectDelivery, InstructorAssignmentRole role) {
			var result = new InstructorAssignment(teacher, subjectDelivery, role);
		    return result;
		}

        public Person Person { get; set; }
        

        public List<InstructorAssignment> Assignments
        {
            get
            {
                return _assignments;
            }

            set
            {
                _assignments = value;
            }
        }

        public string EmployeeId
        {
            get
            {
                return _employeeId;
            }

            set
            {
                _employeeId = value;
            }
        }

        public string OfficeLocation
        {
            get
            {
                return _officeLocation;
            }

            set
            {
                _officeLocation = value;
            }
        }
    }

}
