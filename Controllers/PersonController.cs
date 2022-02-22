using Day9.DTO;
using Day9.Entities;
using Day9.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("/add-person")]
        public void AddPerson([FromBody] PersonDTO person)
        {
            _personService.AddPerson(person);
        }

        [HttpDelete("/delete-person")]
        public void DeletePerson(int id)
        {
            _personService.DeletePerson(id);
        }

        [HttpPut("/edit-person")]
        public void UpdatePerson([FromBody] PersonModel person)
        {
            _personService.UpdatePerson(person);
        }

        [HttpPost("/filter")]
        public List<PersonModel> Filter([FromBody] FilterPersonDTO person)
        {
            return _personService.Filter(person);
        }
    }
}