using CourseFantastic.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFantastic.Domain.Repo
{
    public class FakeCourseDeliveryRepository : IGenericRepository<CourseDelivery>
    {
        private List<CourseDelivery> _courses = new List<CourseDelivery>{ 
            new CourseDelivery(new Course("Become an independant programmer",Qualification.C4Programming),College.Ultimo,"16ULT-201",new FakeSemester(2016,1)),
            new CourseDelivery(new Course("Become an independant developer",Qualification.DipSoftwareDevelopment),College.Ultimo,"16ULT-202",new FakeSemester(2016,2)),
            new CourseDelivery(new Course("Universal Mobile APPS","Learn mobile app development"),College.Ultimo,"16ULT-203",new DateTime(2016,2,16),new DateTime(2016,5,16)),
        };



        public FakeCourseDeliveryRepository()
        {
            _courses = new List<CourseDelivery>();
        }

        public List<CourseDelivery> GetAll()
        {
            return _courses;
        }



        public CourseDelivery GetByCallOccCode(string callOccCode)
        {
            return _courses.Where(c => c.CallOccCode == callOccCode).FirstOrDefault();
        }

        public void Add(CourseDelivery entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(CourseDelivery entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CourseDelivery entity)
        {
            throw new NotImplementedException();
        }

        public string GetNextMajorVersion()
        {
            throw new NotImplementedException();
        }

        public string GetNextMinorVersion()
        {
            throw new NotImplementedException();
        }


        public List<CourseDelivery> GetAll(College college, ISemesterDates semester)
        {
            return _courses.Where(c => c.College == college && c.DeliveryPeriod.Start == semester.Dates["termOneStart"]).ToList();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }
}
