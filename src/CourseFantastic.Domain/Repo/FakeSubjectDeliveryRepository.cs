using CourseFantastic.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFantastic.Domain.Repo
{
    public class FakeSubjectDeliveryRepository : IGenericRepository<SubjectDelivery>
    {
        private List<SubjectDelivery> _subjects;

        public FakeSubjectDeliveryRepository()
        {
            _subjects = new List<SubjectDelivery>();
        }

        public List<SubjectDelivery> GetAll()
        {
            throw new NotImplementedException();
        }

        public SubjectDelivery GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(SubjectDelivery entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(SubjectDelivery entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SubjectDelivery entity)
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


        public List<SubjectDelivery> GetAll(College college, ISemesterDates semester)
        {
            throw new NotImplementedException();
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
