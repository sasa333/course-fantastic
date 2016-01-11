using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseFantastic.Domain.Model
{
    public class FakeSemester : ISemesterDates
    {
        private Dictionary<string, DateTime> _dates;

        public Dictionary<string, DateTime> Dates
        {
            get { return _dates; }
            set { _dates = value; }
        }
        public FakeSemester(int year, int semester)
        {
            Dates = new Dictionary<string, DateTime>();
            Dates.Add("termOneStart", new DateTime(2016, 2, 1));
            Dates.Add("termOneEnd", new DateTime(2016, 4, 1));
            Dates.Add("termTwoStart", new DateTime(2016, 4, 18));
            Dates.Add("termTwoEnd", new DateTime(2016, 6, 17));

        }
    }
}
