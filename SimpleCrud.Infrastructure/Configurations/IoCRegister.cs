using Autofac;
using SimpleCrud.Application.Service;
using SimpleCrud.Application.Service.Interfaces;
using SimpleCrud.Core.Interfaces.Repositories;
using SimpleCrud.Core.Interfaces.Services;
using SimpleCrud.Infrastructure.Adapters.Mapper;
using SimpleCrud.Infrastructure.Adapters.Mapper.Interfaces;
using SimpleCrud.Infrastructure.Repositories;
using SimpleCrud.Infrastructure.Services;

namespace SimpleCrud.Infrastructure.Configurations
{
    public class IoCRegister
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationClientService>().As<IApplicationClientService>();
            builder.RegisterType<ApplicationProductService>().As<IApplicationProductService>();
         
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<ProductService>().As<IProductService>();
         
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
         
            builder.RegisterType<ClientMapper>().As<IClientMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();
        }
    }
}
