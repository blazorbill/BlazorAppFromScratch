using System;
using System.Collections.Generic;
using BlazorAppFromScratch.DTO;

namespace BlazorAppFromScratch.Services
{
    public interface IPersonService
    {
        List<PersonDTO> GetPersons();
        PersonDTO GetPerson(int id);

    }
}
