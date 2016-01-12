using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model {
	public class Timetable {
		public Timetable(Person person, List<TimeTableItem> items)
		{
		    Person = person;
		    Items = items;
		}

		private Person _person;
	    public List<TimeTableItem> Items { get; set; }

        public Person Person
        {
            get
            {
                return _person;
            }

            set
            {
                _person = value;
            }
        }
    }

}
