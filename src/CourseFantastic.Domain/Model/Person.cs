using System;
namespace CourseFantastic.Domain.Model {
	public class Person {
		private string firstName;
		private string surname;
		private DateTime dob;
		private string email;

		public Person( string firstName, string surname, DateTime dob, string email) {
			throw new System.Exception("Not implemented");
		}
		

		private System.Collections.Generic.List<CourseDelivery> enrolments;

		private System.Collections.Generic.List<Timetable> timeTable;
		private Teacher teacher;
		private Student student;

	}

}
