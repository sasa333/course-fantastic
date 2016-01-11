using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public interface Learner {

	    Enrolment Enrol(string callOccCode);
		List<Enrolment> GetActiveEnrolments();

	}

}
