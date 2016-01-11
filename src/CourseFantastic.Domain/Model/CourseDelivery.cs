using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public class CourseDelivery {
		private string location;
		private string callOccCode;
		private string semester;
		private string version;
		private College college;

		public CourseDelivery(Course course, string location, string callOccCode, string version, College college) {
			throw new System.Exception("Not implemented");
		}

		private TimePeriod deliveryPeriod;
		private List<SubjectDelivery> subjects;


	}

}
