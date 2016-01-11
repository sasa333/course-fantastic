using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public class Course {
		private string courseID;
		private string name;
		private string description;

		public Course(string name, string desc) {
			throw new System.Exception("Not implemented");
		}

		private List<Subject> subjects;

		private Qualification qualification;

	}

}
