using Autofac;

namespace SimpleCrud.Infrastructure.Configurations
{
    public class IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IoCRegister.Load(builder);
        }
    }
}
