using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using PersonnelDirectory.Web2.Models;
using PersonnelDirectory.Web2.Models.ViewModels;

namespace PersonnelDirectory.Web2.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IPersonnelModel _personnelModel;

        public PersonController()
        {
            AutomapperConfiguration.Configure();
            _personnelModel = new PersonnelModel();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _personnelModel.GetAllPersonnel();
        }

        public IHttpActionResult GetPerson(string id)
        {
            var person = _personnelModel.GetPerson(Int32.Parse(id));
            return Ok(person);
        }

        public IHttpActionResult PostPerson(Person person)
        {
            var personId = _personnelModel.SavePerson(person);
            return CreatedAtRoute("DefaultApi", 
                new {id = personId}, 
                _personnelModel.GetPerson(personId));
        }

        public IHttpActionResult PutPerson(int id, Person person)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult DeletePerson(int id)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
