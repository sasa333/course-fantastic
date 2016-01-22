using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseFantastic.Api.ViewModels.Person;
using CourseFantastic.Domain.Model;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Extensions;
using Microsoft.AspNet.Mvc;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using CourseFantastic.Application.Users;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseFantastic.Api.Controllers
{
    public static class FakePersonRepositoryFactory
    {
        public static Domain.Repo.FakePersonRepository Create(IServiceProvider serviceProvider)
        {
            var repoPerson = new Domain.Repo.FakePersonRepository();

            repoPerson.Add(new Person("Sasha", "Stevanovic", DateTime.Now, "sasha.s@email.com"));
            repoPerson.Add(new Person("Juan", "Rondon", DateTime.Now, "juan.r@email.com"));
            repoPerson.Add(new Person("Nick", "Attlee", DateTime.Now, "nick.a@email.com"));

            return repoPerson;
        }
    }

    [Route("api/people")]
    public class PeopleController : Controller
    {
        private PeopleApplicationService _servicePerson;
        private IGenericRepository<Person> _repoPerson;

        public PeopleController(PeopleApplicationService servicePerson, IGenericRepository<Person> repoPerson)
        {
            _servicePerson = servicePerson;
            _repoPerson = repoPerson;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repoPerson.GetAll().Select(p => new PersonGeneralViewModel()
            {
                FirstName = p.FirstName,
                Surname = p.Surname,
                Email = p.Email,
                DoB = p.Dob
            }).ToList();


            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PersonGeneralViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            var person = await _servicePerson.CreatePerson(model.FirstName, model.Surname, model.DoB, model.Email, String.Empty);

            model.Identity = person.Identity;

            // TODO: Look at how we want to have global identity for the person domain concept
            return Created(Request.GetEncodedUrl() + model.GetHashCode(), model);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PersonGeneralViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            var person = _repoPerson.GetById(id.ToString());

            if (person == null)
            {
                return HttpNotFound();
            }

            person.FirstName = model.FirstName;
            person.Surname = model.Surname;
            person.Dob = model.DoB;
            person.Email = model.Email;

            _repoPerson.Update(person);

            return Ok(model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
