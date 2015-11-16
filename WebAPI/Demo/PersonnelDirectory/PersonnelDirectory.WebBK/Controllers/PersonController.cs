using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PersonnelDirectory.Web.Models.ViewModels;
using PersonnelDirectory.Web.Models;

namespace PersonnelDirectory.Web.Controllers
{
    public class PersonController : ApiController
    {
        private IPersonnelModel _personModel = new PersonnelModel();

        public PersonController()
        {
            AutomapperConfiguration.Configure();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _personModel.GetAllPersonnel();
        }

        public Person GetPeople(int id)
        {
            var person = _personModel.GetPerson(id);
            return person;
        }

        public int PostPerson(Person person)
        {
            return 99;
        }
    }
}
