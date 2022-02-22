using Day9.DB;
using Day9.DTO;
using Day9.Entities;
using Day9.Enum;

namespace Day9.Services
{
    public class PersonService : IPersonService
    {
        private PersonContext _context;

        public PersonService(PersonContext context)
        {
            _context = context;
        }

        public void AddPerson(PersonDTO person)
        {
            _context.People.Add(new PersonModel
            {
                FirstName = person.FirstName,
                Lastname = person.Lastname,
                Gender = person.Gender,
                DateOfBirth = person.DateOfBirth,
                BirthPlace = person.BirthPlace
            });

            _context.SaveChanges();
        }

        public List<PersonModel> Filter(FilterPersonDTO person)
        {
            return _context.People.Where(x =>
                !string.IsNullOrEmpty(person.FirstName) && (x.FirstName.ToLower() == person.FirstName.ToLower())
                || !string.IsNullOrEmpty(person.Lastname) && (x.Lastname.ToLower() == person.Lastname.ToLower())
                || (x.Gender == person.Gender)
                || (x.BirthPlace.ToLower() == person.BirthPlace.ToLower())).ToList();
        }

        public void UpdatePerson(PersonModel person)
        {
            var item = _context.People.FirstOrDefault(x => x.Id == person.Id);
            if (item != null)
            {
                item.FirstName = person.FirstName;
                item.Lastname = person.Lastname;
                item.Gender = person.Gender;
                item.DateOfBirth = person.DateOfBirth;
                item.BirthPlace = person.BirthPlace;

                _context.SaveChanges();
            }
        }
        public void DeletePerson(int id)
        {
            var item = _context.People.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.People.Remove(item);
                
                _context.SaveChanges();
            }
        }
    }
}