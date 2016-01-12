using System;
using System.Collections.Generic;

namespace CourseFantastic.Domain.Model
{
    public interface Learner
    {
        Enrolment CreateEnrolment(CourseDelivery course);
        List<Enrolment> GetActiveEnrolments();

        Attendance CheckIn(DateTime start);
        Attendance CheckOut(DateTime end);

    }

}
