using CourseFantastic.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseFantastic.Application.Users
{
    public class PeopleApplicationService
    {
        private IGenericRepository<Person> _repoPerson;

        public PeopleApplicationService(IGenericRepository<Person> repoPerson)
        {
            _repoPerson = repoPerson;
        }

        public async Task<Person> CreatePerson(string firstName, string surname, DateTime dob, string email, string mobile)
        {
            var person = new Person(
                firstName: firstName,
                surname: surname,
                dob: dob,
                email: email,
                mobile: mobile
                );

            var context = new DataAccess.Models.CourseFantasticDbContext();
            var dbPerson = new DataAccess.Models.Person()
            {
                FirstName = person.FirstName,
                Surname = person.Surname,
                DoB = person.Dob,
                Email = person.Email
            };
            context.People.Add(dbPerson);
            await context.SaveChangesAsync();

            person = await _repoPerson.Add(person);

            dbPerson.Identity = person.Identity;
            context.SaveChangesAsync();

            return person;
        }
    }
}
