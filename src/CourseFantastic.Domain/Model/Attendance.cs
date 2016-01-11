using System;
namespace CourseFantastic.Domain.Model {
	public class Attendance {
		private DateTime checkIn;
		private DateTime checkOut;

		public Attendance(DateTime checkIn) {
			throw new System.Exception("Not implemented");
		}
		public DateTime GetCheckOut() {
			return this.checkOut;
		}
		public void SetCheckOut(DateTime checkOut) {
			this.checkOut = checkOut;
		}

		private Learner learner;
		private TimeTableItem session;

	}

}
