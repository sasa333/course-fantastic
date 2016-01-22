using CourseFantastic.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseFantastic.Domain.Repo
{
    public class FakePersonRepository : IGenericRepository<Person>
    {
        private List<Person> _people;

        public FakePersonRepository()
        {
            _people = new List<Person>();
        }

        public async Task<Person> Add(Person entity)
        {
            _people.Add(entity);
            return entity;
        }

        public List<Person> GetAll()
        {
            return _people;
        }

        public Person GetById(string id)
        {
            // TODO: Implement the identify for all domain entities

            return _people.FirstOrDefault();
        }

        public string GetNextMajorVersion()
        {
            throw new NotImplementedException();
        }

        public string GetNextMinorVersion()
        {
            throw new NotImplementedException();
        }

        public void Remove(Person entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            // TODO: Decide whether to implement the fake version of this
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
