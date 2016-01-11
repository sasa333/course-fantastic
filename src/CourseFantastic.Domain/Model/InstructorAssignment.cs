using System;
namespace CourseFantastic.Domain.Model {
	public class InstructorAssignment {
		private string instructorID;
		private string subjectDeliveryID;
		private Boolean isActive;

		public InstructorAssignment(string instructorID, string subjectDeliveryID) {
			throw new System.Exception("Not implemented");
		}
		public Boolean GetIsActive() {
			return this.isActive;
		}
		public void SetIsActive(Boolean isActive) {
			this.isActive = isActive;
		}
		public InstructorAssignment (string instructorID, string subjectDeliveryID, InstructorAssignmentRole role) {
			throw new System.Exception("Not implemented");
		}

		private InstructorAssignmentRole role;
		private SubjectDelivery subject;

		private Teacher instructor;

	}

}
