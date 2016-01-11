using System;
namespace CourseFantastic.Domain.Model {
	public class Enrolment {
        private Learner _learner;

        public Learner Learner
        {
            get { return _learner; }
            set { _learner = value; }
        }
        private CourseDelivery _courseRun;

        public CourseDelivery CourseRun
        {
            get { return _courseRun; }
            set { _courseRun = value; }
        }

		public Enrolment(Learner learner, CourseDelivery courseRun) {
            Learner = learner;
            CourseRun = courseRun;
		}

	}

}
