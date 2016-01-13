using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseFantastic.Domain.Model;
using CourseFantastic.Domain.Repo;

namespace CourseFantastic.Domain.Services
{
    public class CourseService : ICourseService
    {
        //TODO: fix this to run all the time
        FakeCourseDeliveryRepository repo = new FakeCourseDeliveryRepository();
        public CourseDelivery FetchCourse(string callOccCode)
        {
            return repo.GetById(callOccCode);
        }

        public List<CourseDelivery> FetchCourses(FakeSemester semester, College college)
        {
            return repo.GetAll(college, semester);
        }
    }
}
