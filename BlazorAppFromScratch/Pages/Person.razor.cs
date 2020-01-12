﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAppFromScratch.DTO;
using BlazorAppFromScratch.Client.BL;
using Microsoft.AspNetCore.Components;

namespace BlazorAppFromScratch.Pages
{
    public partial class Person
    {
        private List<PersonDTO> MyPersons = new List<PersonDTO>();
        private PersonDTO MyPerson = new PersonDTO();

        [Inject]
        private IPersonService personService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            MyPersons = await personService.GetPersons();
            MyPerson = await personService.GetPerson(1);
        }

        async Task OnPersonSelect(ChangeEventArgs e)
        {
            int id = int.Parse(e.Value.ToString());
            MyPerson = await personService.GetPerson(id);
        }
    }
}
