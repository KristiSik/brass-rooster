using System.Linq;
using BrassRooster.Domain.Models;
using BrassRooster.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace BrassRooster.Infrastructure.Persistence
{
    internal class BrassRoosterDbContext : DbContext, IBrassRoosterDbContext
    {
        public const string Schema = "BrassRooster";

        public BrassRoosterDbContext(DbContextOptions<BrassRoosterDbContext> options)
            : base(options)
        {
        }

        IQueryable<Employee> IBrassRoosterDbContext.Employees => Set<Employee>();

        IQueryable<TestServer> IBrassRoosterDbContext.TestServers => Set<TestServer>();

        void IBrassRoosterDbContext.Add<TEntity>(TEntity entity)
        {
            Set<TEntity>().Add(entity);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BrassRoosterDbContext).Assembly);
        }
    }
}