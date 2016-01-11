using System;
namespace CourseFantastic.Domain.Model
{
    public class Attendance
    {
        private DateTime _checkIn;
        public DateTime CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }

        private DateTime _checkOut;
        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        private Learner _learner;

        public Learner Learner
        {
            get { return _learner; }
            set { _learner = value; }
        }

        private TimeTableItem _session;

        public TimeTableItem Session
        {
            get { return _session; }
            set { _session = value; }
        }

        public Attendance(DateTime checkIn)
        {
            CheckIn = checkIn;
        }

    }

}
