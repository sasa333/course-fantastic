using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public class TimeTableItem {
		private string _location;
        public TimeTableItem(TimePeriod timePeriod, string location)
        {
            TimePeriod = timePeriod;
            Location = location;
        }
        public TimeTableItem(DateTime starTime, DateTime endTime, String location): this(new TimePeriod(starTime, endTime), location )
	    {
	            
	    }
       

		private TimePeriod _timePeriod;
		private List<Attendance> _roll;

        public TimePeriod TimePeriod
        {
            get
            {
                return _timePeriod;
            }

            set
            {
                _timePeriod = value;
            }
        }

        public List<Attendance> Roll
        {
            get
            {
                return _roll;
            }

            set
            {
                _roll = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }
    }

}
