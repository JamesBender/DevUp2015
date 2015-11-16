using System.Collections.Generic;

namespace PersonnelDirectory.Core
{
    public interface IPersonRepository
    {
        Person GetPerson(int userId);
        int SavePerson(Person addedPerson);
        int UpdatePerson(Person updatedPerson);
        void DeletePerson(int userId);
        ICollection<Person> GetListOfPeople();
    }
}