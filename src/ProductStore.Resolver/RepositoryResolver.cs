using Autofac;
using ProductStore.Data.Memory;
using ProductStore.Repository.Interfaces;

namespace ProductStore.Resolver
{
    public class RepositoryResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //default
            builder.RegisterType<ProductRepository>().AsImplementedInterfaces();
            //todo: names should be an enum or CONST
            builder.RegisterType<Data.Memory.ProductRepository>().Named<IProductRepository>("memory");
            builder.RegisterType<Data.Xml.ProductRepository>().Named<IProductRepository>("xml");
        }
    }
}
