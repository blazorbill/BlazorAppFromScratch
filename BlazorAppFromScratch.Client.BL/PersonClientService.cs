using BlazorAppFromScratch.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Client.BL
{
    public class PersonClientService : IPersonClientService
    {
        public PersonClientService()
        {

        }
        public async Task<List<PersonDTO>> GetPersons()
        {
            return await HTTPHelper.HttpGet<List<PersonDTO>>("persons");
        }
        public async Task<PersonDTO> GetPerson(int id)
        {
            return await HTTPHelper.HttpGet<PersonDTO>($"person/{id}");
        }
    }
}
