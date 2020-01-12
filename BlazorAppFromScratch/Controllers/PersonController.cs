using BlazorAppFromScratch.DTO;
using BlazorAppFromScratch.Server.BL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorAppFromScratch.Controllers
{
    [Produces("application/json")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/persons
        [HttpGet("api/persons")]
        public List<PersonDTO> Get()
        {
            return _personService.GetPersons();
        }
        // GET: api/<controller>
        [HttpGet("api/person/{id}")]
        public PersonDTO Get(int id)
        {
            return _personService.GetPerson(id);
        }
    }

}
