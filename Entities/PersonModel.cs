using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Day9.Enum;

namespace Day9.Entities
{
    public class PersonModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        
        public string? FirstName { get; set; }

        public string? Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        
        public string? BirthPlace { get; set; }
    }
}