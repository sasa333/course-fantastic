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

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseFantastic.Api.Controllers
{
    [Route("api/people")]
    public class PeopleController : Controller
    {
        private IGenericRepository<Person> _repoPerson; 

        public PeopleController(IGenericRepository<Person> repoPerson)
        {
            _repoPerson = repoPerson;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            // TODO: Get all the people from the data store
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]PersonGeneralViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            var person = new Person(
                firstName: model.FirstName,
                surname: model.Surname,
                dob: model.DoB,
                email: model.Email
                );

            _repoPerson.Add(person);

            // TODO: Look at how we want to have global identity for the person domain concept
            return Created(Request.GetEncodedUrl() + model.GetHashCode(), model);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
