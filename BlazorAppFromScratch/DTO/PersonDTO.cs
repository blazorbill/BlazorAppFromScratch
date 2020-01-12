using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.DTO
{
    public class PersonDTO
    {
        [Required]
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Range(21, 2000, ErrorMessage ="You must be at least 21 years old.")]
        public int Age { get; set; }
        public string Gender { get; set; } = "";
        public bool HasPets { get; set; } = false;
        public string PetType { get; set; } = "";
    }
}
