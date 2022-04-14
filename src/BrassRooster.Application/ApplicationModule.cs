using Autofac;

namespace BrassRooster.Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(typeof(ApplicationModule).Assembly)
                .Where(t => t.Name.EndsWith("AppService"))
                .AsSelf();
        }
    }
}
