using BrassRooster.Domain.Enums;

namespace BrassRooster.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public AvailabilityStatus AvailabilityStatus { get; set; }
    }
}
