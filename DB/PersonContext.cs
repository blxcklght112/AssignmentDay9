using Day9.Entities;
using Day9.Enum;
using Microsoft.EntityFrameworkCore;

namespace Day9.DB
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }

        public DbSet<PersonModel> People { get; set; }

    }
}