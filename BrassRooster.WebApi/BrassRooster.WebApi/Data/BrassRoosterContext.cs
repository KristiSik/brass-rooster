using BrassRooster.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace BrassRooster.WebApi.Data
{
    public class BrassRoosterContext : DbContext
    {
        public BrassRoosterContext(DbContextOptions<BrassRoosterContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<TestServer> TestServers { get; set; }
    }
}
