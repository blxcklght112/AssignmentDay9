using Day9.DTO;
using Day9.Entities;

namespace Day9.Services
{
    public interface IPersonService
    {
        void AddPerson(PersonDTO person);

        List<PersonModel> Filter(FilterPersonDTO person);

        void UpdatePerson(PersonModel person);

        void DeletePerson(int id);
    }
}