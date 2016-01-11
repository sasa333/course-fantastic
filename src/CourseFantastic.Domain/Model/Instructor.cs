using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public interface Instructor {

		InstructorAssignment CreateAssignment( string employeeID,  string subjectDeliveryID,  InstructorAssignmentRole role);
		List<InstructorAssignment> FetchActiveAssignments();

	}

}
