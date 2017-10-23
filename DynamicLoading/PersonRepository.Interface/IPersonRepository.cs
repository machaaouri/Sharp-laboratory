using System.Collections.Generic;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson(Person newPerson);

        void UpdatePerson(string lastName, Person updatedPerson);

        void UpdatePeople(IEnumerable<Person> updatePeople);

        void DeletePerson(string lastName);

        

    }
}
