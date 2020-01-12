using System;
using System.Collections.Generic;
using System.Linq;
using BlazorAppFromScratch.DTO;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Services
{
    public class PersonService : IPersonService
    {

        private List<PersonDTO> Persons;

        public PersonService()
        {
            InitializePersons();
        }
        private void InitializePersons()
        {
            Persons = new List<PersonDTO>()
            {
                new PersonDTO()
                {
                    ID=1,
                    FirstName = "Fred",
                    LastName = "Flintstone",
                    Gender = "Male"
                },
                new PersonDTO()
                {
                    ID=2,
                    FirstName = "Wilma",
                    LastName = "Flintstone",
                    Gender = "Female"
                },
                new PersonDTO()
                {
                    ID=3,
                    FirstName = "Barney",
                    LastName = "Rubble",
                    Gender = "Male"
                },
                new PersonDTO()
                {
                    ID=4,
                    FirstName = "Betty",
                    LastName = "Rubble",
                    Gender = "Female"
                }
            };
        }
        public List<PersonDTO> GetPersons() => Persons;
        public PersonDTO GetPerson(int id)
        {
            return Persons.Where(p => p.ID == id).FirstOrDefault();
        }
    }

}
