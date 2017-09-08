using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using  ProductStore.Data.Memory;

namespace ProductStore.Resolver
{
    public class RepositoryResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>().AsImplementedInterfaces();
        }
    }
}
