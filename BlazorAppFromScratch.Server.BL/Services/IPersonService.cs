using System;
using System.Collections.Generic;
using BlazorAppFromScratch.DTO;

namespace BlazorAppFromScratch.Server.BL.Services
{
    public interface IPersonService
    {
        List<PersonDTO> GetPersons();
        PersonDTO GetPerson(int id);

    }
}
