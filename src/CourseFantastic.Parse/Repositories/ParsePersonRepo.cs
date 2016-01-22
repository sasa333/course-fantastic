using CourseFantastic.Domain.Model;
using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseFantastic.Parse.Repositories
{
    public class ParsePersonRepo : IGenericRepository<Person>
    {
        public async Task<Person> Add(Person entity)
        {
            var parseObject = new ParseObject("Person");
            parseObject["FirstName"] = entity.FirstName;
            parseObject["Surname"] = entity.Surname;
            parseObject["Dob"] = entity.Dob;
            parseObject["Email"] = entity.Email;
            parseObject["Mobile"] = entity.Mobile;

            await parseObject.SaveAsync();

            entity.Identity = parseObject.ObjectId;
            return entity;
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(string id)
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

        public void Remove(Person entity)
        {
            throw new NotImplementedException();
        }

        public async void Update(Person entity)
        {
            var parseObject = await ParseObject.GetQuery("Person").GetAsync(entity.Identity);

            parseObject["FirstName"] = entity.FirstName;
            parseObject["Surname"] = entity.Surname;
            parseObject["Dob"] = entity.Dob;
            parseObject["Mobile"] = entity.Mobile;

            await parseObject.SaveAsync();
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

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ParsePersonRepo() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
