using System;
using System.Collections.Generic;
namespace CourseFantastic.Domain.Model {
	public class SubjectDelivery {
		private string version;

		public SubjectDelivery(Subject subject) {
			throw new System.Exception("Not implemented");
		}

		private List<AssessmentEvent> assessments;
		private List<Bulletin> subjectNews;

		private CourseDelivery courseDeatils;
		private List<TimeTableItem> sessions;
		private List<InstructorAssignment> instructors;

	}

}
