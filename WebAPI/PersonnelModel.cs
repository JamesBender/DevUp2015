using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using PersonnelDirectory.Core;
using Person = PersonnelDirectory.Web.Models.ViewModels.Person;

namespace PersonnelDirectory.Web.Models
{
    public interface IPersonnelModel
    {
        IEnumerable<Person> GetAllPersonnel();
        Person GetPerson(int id);
        int SavePerson(Person person);
        int SavePerson(int id, Person person);
        void DeletePerson(int id);
    }

    public class PersonnelModel : IPersonnelModel
    {
        private readonly IPersonRepository _personRepository = new PersonRepository();

        public IEnumerable<Person> GetAllPersonnel()
        {
            return
                _personRepository.GetListOfPeople()
                                 .Select(Mapper.Map<Core.Person, Person>)
                                 .ToList();
        }

        public Person GetPerson(int id)
        {
            var person = _personRepository.GetPerson(id);

            return Mapper.Map<Core.Person, Person>(person);
        }

        public int SavePerson(Person person)
        {
            return _personRepository.SavePerson(Mapper.Map<Person, Core.Person>(person));
        }

        public int SavePerson(int id, Person person)
        {
            return _personRepository.SavePerson(id, Mapper.Map<Person, Core.Person>(person));
        }

        public void DeletePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }
    }
}