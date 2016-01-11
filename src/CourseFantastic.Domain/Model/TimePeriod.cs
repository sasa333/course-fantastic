using System;
namespace CourseFantastic.Domain.Model {
	public class TimePeriod {
        private DateTime _start;

        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }
        private DateTime _end;

        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

		
		public string GetFormatted() {
            return String.Format("From: {0:d} to {1:d}", Start, End);
		}
		public TimePeriod(DateTime start, DateTime end) {
            Start = start;
            End = end;
		}


	}

}
