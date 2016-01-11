using System;
namespace CourseFantastic.Domain.Model {
	public class Bulletin {
		private DateTime dateCreated;
		private DateTime publishDate;
		private string title;
		private string body;

		public Bulletin(DateTime publishDate, string title, string body) {
			throw new System.Exception("Not implemented");
		}
		public Bulletin(string title, string body) {
			throw new System.Exception("Not implemented");
		}

		private SubjectDelivery subjectDelivery;

	}

}
