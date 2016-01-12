using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public interface Instructor {

		InstructorAssignment CreateAssignment( Instructor teacher,  SubjectDelivery subject,  InstructorAssignmentRole role);
		List<InstructorAssignment> FetchActiveAssignments();

	}

}
