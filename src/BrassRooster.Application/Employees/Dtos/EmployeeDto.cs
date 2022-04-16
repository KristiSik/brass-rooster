using BrassRooster.Domain.Enums;

namespace BrassRooster.Application.Employees.Dtos
{
    public record EmployeeDto
    {
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public Role Role { get; init; }
        public AvailabilityStatus AvailabilityStatus { get; init; }
    }
}