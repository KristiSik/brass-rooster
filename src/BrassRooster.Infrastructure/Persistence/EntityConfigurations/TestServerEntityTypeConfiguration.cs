using BrassRooster.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrassRooster.Infrastructure.Persistence.EntityConfigurations
{
    internal class TestServerEntityTypeConfiguration : IEntityTypeConfiguration<TestServer>
    {
        public void Configure(EntityTypeBuilder<TestServer> builder)
        {
            builder
                .ToTable("TestServers", BrassRoosterDbContext.Schema);

            builder
                .HasKey(x => x.Id);
        }
    }
}
