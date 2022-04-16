using BrassRooster.Domain.Enums;

namespace BrassRooster.Application.TestServers.Dtos
{
    public record TestServerDto
    {
        public int Id { get; init; }
        public string Host { get; init; }
        public string Name { get; init; }
        public UsageState UsageState { get; init; }
    }
}