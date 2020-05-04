using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PersonRepository.Interface
{
    public class CSVRepository : IPersoonRepository
    {

        string file_name { get; set; }
        public CSVRepository()
        {
            var file_name = "People.csv";
            
        }

        public void AddPerson(Person newPerson)
        {

            // not going to implelmemt
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            // not going to implement
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            
            
            // listis under the iEnumrable
            // make  a people list
            List<Person> people = new List<Person>();
            if (File.Exists(file_name))
            {
                using (var reader = new StreamReader(file_name))
                {

                    // this using statement is used for grabage colletion
                    string line;
                    while((line=reader.ReadLine())!= null)
                    {
                        // split the data
                        var elements = line.Split(',');
                        // create the person object
                        var person = new Person
                        {
                            Id = Int32.Parse(elements[0]),
                            GivenName = elements[1],
                            FamilyName = elements[2],
                            StartDate = DateTime.Parse(elements[3]),
                            Rating = Int32.Parse(elements[4])
                        };

                        people.Add(person);
                    }
                }
                
            }
            return people;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedperson)
        {   
            // not going to implement
            throw new NotImplementedException();
        }
    }
}
