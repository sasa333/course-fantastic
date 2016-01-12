using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFantastic.Domain.Model
{
    public interface IGenericRepository<T> : IDisposable
    {
        List<T> GetAll();
        List<T> GetAll(College college, ISemesterDates semester);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        string GetNextMajorVersion();
        string GetNextMinorVersion();
    }
}
