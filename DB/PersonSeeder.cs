using Day9.Entities;
using Day9.Enum;

namespace Day9.DB
{
    public class PersonSeeder
    {
        private readonly PersonContext _context;

        public PersonSeeder(PersonContext context)
        {
            _context = context;
        }

        public void SeedData(){
            _context.People.AddRange(new List<PersonModel>
            {
                new PersonModel
                {
                    Id = 1,
                    FirstName = "Loc",
                    Lastname = "Pham Duc",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1999, 1, 12),
                    BirthPlace = "Nghe An"
                },
                new PersonModel
                {
                    Id = 2,
                    FirstName = "Nhung",
                    Lastname = "Nguyen Hong",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(2000, 6, 29),
                    BirthPlace = "Thai Binh"
                },
                new PersonModel
                {
                    Id = 3,
                    FirstName = "Hai",
                    Lastname = "Nguyen Tien",
                    Gender = Gender.Other,
                    DateOfBirth = new DateTime(2003, 12, 31),
                    BirthPlace = "Thai Nguyen"
                }
            });

            _context.SaveChanges();
        }
    }
}