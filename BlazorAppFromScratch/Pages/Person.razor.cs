using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorAppFromScratch.DTO;
using BlazorAppFromScratch.Services;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace BlazorAppFromScratch.Pages
{
    public partial class Person
    {
        private List<PersonDTO> MyPersons = new List<PersonDTO>();
        private PersonDTO MyPerson = new PersonDTO();

        [Inject]
        private IPersonService personService { get; set; }

        protected override void OnInitialized()
        {
            MyPersons = personService.GetPersons();
            MyPerson = personService.GetPerson(1);
        }

        void OnPersonSelect(ChangeEventArgs e)
        {
            int id = int.Parse(e.Value.ToString());
            MyPerson = personService.GetPerson(id);
        }
    }
}
