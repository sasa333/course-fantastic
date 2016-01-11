using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseFantastic.Domain.Model;

namespace CourseFantastic.Domain.Services
{
    public interface ICourseService
    {
        CourseDelivery FetchCourse(string callOccCode);
        List<CourseDelivery> FetchCourses(FakeSemester semester, College college);

    }
}
