using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using PersonnelDirectory.Core;


namespace PersonnelDirectory.WCF
{
    public class DirectoryService : IDirectoryService
    {
        private readonly PersonRepository _personRepository = new PersonRepository();

        private Person GetPersonFromService(int userId)
        {            
            var domainPerson = _personRepository.GetPerson(userId);
            return domainPerson == null ? null : MapDomainPersonToModelPerson(domainPerson);
        }

        private static Person MapDomainPersonToModelPerson(Core.Person domainPerson)
        {
            return new Person
            {
                UserId = domainPerson.UserId,
                FirstName = domainPerson.FirstName,
                LastName = domainPerson.LastName,
                Department = domainPerson.Department,
                Title = domainPerson.Title
            };
        }

        private int SavePersonWithService(Person person)
        {
            _personRepository.SavePerson(new Core.Person
            {
                UserId = person.UserId,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Department = person.Department,
                Title = person.Title
            });
            return person.UserId;
        }

        private int UpdatePersonWithService(Person person)
        {
            _personRepository.UpdatePerson(new Core.Person
                                               {
                                                   UserId = person.UserId,
                                                   FirstName = person.FirstName,
                                                   LastName = person.LastName
                                               });
            return person.UserId;
        }
        public Person GetJsonPerson(string userId)
        {
            var id = ParseUserId(userId);
            return GetPersonFromService(id);
        }

        public List<Person> GetJsonPeople()
        {
            return GetListOfPeople();
        }

        public List<Person> GetPeople()
        {
            return GetListOfPeople();
        }

        private List<Person> GetListOfPeople()
        {
            return _personRepository.GetListOfPeople().Select(MapDomainPersonToModelPerson).ToList();
        }

        public Person GetPerson(string userId)
        {
            var id = ParseUserId(userId);
            return GetPersonFromService(id);
        }

        public string PostPerson(Person person)
        {
            return SavePersonWithService(person).ToString(CultureInfo.InvariantCulture);
        }

        public string PostJsonPerson(Person person)
        {
            return SavePersonWithService(person).ToString(CultureInfo.InvariantCulture);
        }

        public string UpdatePerson(string userId, Person person)
        {
            return UpdatePersonWithService(person).ToString(CultureInfo.InvariantCulture);
        }

        public string UpdateJsonPerson(string userId, Person person)
        {
            return UpdatePersonWithService(person).ToString(CultureInfo.InvariantCulture);
        }

        public void DeletePerson(string userId)
        {
            var id = ParseUserId(userId);
            _personRepository.DeletePerson(id);
        }

        private static int ParseUserId(string userId)
        {
            try
            {
                return int.Parse(userId);
            }
            catch (Exception)
            {
                SetHttpErrorCode(HttpStatusCode.BadRequest);
                throw;
            }
        }

        private static void SetHttpErrorCode(HttpStatusCode errorStatus)
        {
            var webOperationContext = WebOperationContext.Current;
            if (webOperationContext != null)
                webOperationContext.OutgoingResponse.StatusCode = errorStatus;
        }
    }
}