using System;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.Data.OData.Metadata;
using PersonnelDirectory.Web.Models;
using PersonnelDirectory.Web.Models.ViewModels;

namespace PersonnelDirectory.Web.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IPersonnelModel _personnelModel;

        public PersonController()
        {
            AutomapperConfiguration.Configure();
            _personnelModel = new PersonnelModel();
        }

        public IEnumerable<Person> Get()
        {
            return _personnelModel.GetAllPersonnel();
        }

        public Person GetPerson(string id)
        {
            var person = _personnelModel.GetPerson(Int32.Parse(id));
            return person;
        }

        public int PostPerson(Person person)
        {
            return _personnelModel.SavePerson(person);
        }
    }
}
