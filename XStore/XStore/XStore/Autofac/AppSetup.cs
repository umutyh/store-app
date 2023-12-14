using Autofac;
using AutoMapper;
using XStore.Service.OrderService;
using XStore.Service.ProductService;
using XStore.Service.UsersService;
using XStoreApp.Mapper;

namespace XStoreApp.Autofac
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder cb)
        {
            // Automapper
            cb.Register(context => new MapperConfiguration(cfg =>
            {
                //Register Mapper Profile
                cfg.AddProfile<MapperProfile>();
                cfg.AddProfile<AutoMapperProfile>();
            }
            )).AsSelf().SingleInstance();

            cb.Register(c =>
            {
                //This resolves a new context that can be used later.
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
            // Automapper

            cb.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            cb.RegisterType<UserService>().As<IUserService>().SingleInstance();
            cb.RegisterType<OrderService>().As<IOrderService>().SingleInstance();
        }
    }
}
