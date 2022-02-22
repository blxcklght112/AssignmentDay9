using Day9.Enum;

namespace Day9.DTO
{
    public class FilterPersonDTO
    {
        public string? FirstName { get; set; }

        public string? Lastname { get; set; }

        public Gender Gender { get; set; }

        public string? BirthPlace { get; set; }
    }
}