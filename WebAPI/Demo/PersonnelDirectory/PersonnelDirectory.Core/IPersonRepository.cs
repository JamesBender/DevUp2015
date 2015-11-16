using System.Collections.Generic;

namespace PersonnelDirectory.Core
{
    public interface IPersonRepository
    {
        Person GetPerson(int userId);
        int SavePerson(Person addedPerson);
        int SavePerson(int id, Person savedPerson);
        int UpdatePerson(Person updatedPerson);
        void DeletePerson(int userId);
        IEnumerable<Person> GetListOfPeople();
    }
}