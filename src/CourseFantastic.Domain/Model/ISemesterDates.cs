using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseFantastic.Domain.Model
{
    public interface ISemesterDates
    {
         Dictionary<string, DateTime> Dates {get; set;}

    }
}
