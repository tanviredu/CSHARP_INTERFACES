using System.Collections;
using System.Collections.Generic;

namespace PersonRepository.Interface
{
    // make  interface to interact with the data
    public interface IPersoonRepository
    {

        // make all the contract
        // this method return a Enumrable of person object
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
        void AddPerson(Person newPerson);
        void UpdatePerson(int id, Person updatedperson);
        void DeletePerson(int id);

    }


}
