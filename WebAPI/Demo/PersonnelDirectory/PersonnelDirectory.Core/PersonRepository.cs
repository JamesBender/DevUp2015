using System;
using System.Collections.Generic;

namespace PersonnelDirectory.Core
{
    public class PersonRepository : IPersonRepository
    {
        private static readonly IDictionary<int, Person> PersonList = new Dictionary<int, Person>();

        private readonly Person _samplePerson =
            new Person
            {
                FirstName = "Fred",
                LastName = "Flinstone",
                Title = "Worker",
                Department = "Rock Quarry"
            };

        public PersonRepository()
        {
            if (PersonList.Count != 0) return;
            _samplePerson.UserId = PersonList.Count + 1;
            PersonList.Add(_samplePerson.UserId, _samplePerson);
        }

        public Person GetPerson(int userId)
        {
            return PersonList.ContainsKey(userId) ? PersonList[userId] : null;
        }

        public int SavePerson(Person addedPerson)
        {
            if (addedPerson.UserId != 0)
            {
                return UpdatePerson(addedPerson);
            }

            var newUserId = PersonList.Count + 1;
            addedPerson.UserId = newUserId;
            PersonList.Add(addedPerson.UserId, addedPerson);

            return addedPerson.UserId;
        }

        public int SavePerson(int id, Person savedPerson)
        {
            PersonList.Add(id, savedPerson);

            return id;
        }

        public int UpdatePerson(Person updatedPerson)
        {
            if (PersonList.ContainsKey(updatedPerson.UserId))
            {
                PersonList[updatedPerson.UserId] = updatedPerson;
            }
            else
            {
                throw new ArgumentException("Person has a user id but does not exist in data store");
            }

            return updatedPerson.UserId;
        }

        public void DeletePerson(int userId)
        {
            if (PersonList.ContainsKey(userId))
            {
                PersonList.Remove(userId);
            }
        }

        public IEnumerable<Person> GetListOfPeople()
        {
            return PersonList.Values;
        }
    }
}