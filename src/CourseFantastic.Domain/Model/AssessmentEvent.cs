using System;
namespace CourseFantastic.Domain.Model {
	public class AssessmentEvent {
		/// <summary>
		/// either due date or assessment date depending on the assessment type
		/// i.e. Portfolio type would have startDate, endDate while Exam may only have date
		/// </summary>
		private DateTime briefingDate;
		private string location;

		public AssessmentEvent(AssessmentType type, string location, SubjectDelivery subject) {
			;
		}
		public AssessmentEvent(AssessmentType type, string location, DateTime briefingDate, SubjectDelivery subject) {
			throw new System.Exception("Not implemented");
		}
		public AssessmentEvent(AssessmentType type, string location, SubjectDelivery subject, DateTime startDate, DateTime endDate) {
			throw new System.Exception("Not implemented");
		}

		private TimePeriod timePeriod;
		private AssessmentType type;

		private SubjectDelivery _subject;

        public SubjectDelivery Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        public AssessmentType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }

}
