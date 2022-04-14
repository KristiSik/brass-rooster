using BrassRooster.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrassRooster.Infrastructure.Persistence.EntityConfigurations
{
    internal class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("Employees", BrassRoosterDbContext.Schema);

            builder
                .HasKey(x => x.Id);
        }
    }
}
