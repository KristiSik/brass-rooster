using System;
using Autofac;
using BrassRooster.Domain.Services;
using BrassRooster.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BrassRooster.Infrastructure
{
    public class InfrastructureModule : Module
    {
        private const string AppPathToken = "{AppPath}";
        private const string DbConnectionStringName = "DefaultConnection";

        protected override void Load(ContainerBuilder builder)
        {
            builder
                .Register(componentContext =>
                {
                    var serviceProvider = componentContext.Resolve<IServiceProvider>();
                    var configuration = componentContext.Resolve<IConfiguration>();

                    var connectionString = configuration.GetConnectionString(DbConnectionStringName).Replace(AppPathToken, AppContext.BaseDirectory);

                    var optionsBuilder = new DbContextOptionsBuilder<BrassRoosterDbContext>()
                        .UseApplicationServiceProvider(serviceProvider)
                        .UseSqlite(connectionString);

                    return optionsBuilder.Options;
                })
                .As<DbContextOptions<BrassRoosterDbContext>>()
                .InstancePerLifetimeScope();

            builder
                .Register(context => context.Resolve<DbContextOptions<BrassRoosterDbContext>>())
                .As<DbContextOptions>()
                .InstancePerLifetimeScope();

            builder
                .RegisterType<BrassRoosterDbContext>()
                .As<IBrassRoosterDbContext>()
                .InstancePerLifetimeScope();
        }
    }
}
