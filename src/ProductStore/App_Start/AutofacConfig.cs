using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using ProductStore.Resolver;

namespace ProductStore.App_Start
{
    public class AutofacConfig
    {
        public static void Setup()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            
            
            //builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterModule<RepositoryResolver>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // OPTIONAL: Enable action method parameter injection (RARE).
            //builder.InjectActionInvoker();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //var builder = new ContainerBuilder();
            //var config = GlobalConfiguration.Configuration; //new HttpConfiguration(); for owin
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //builder.RegisterModule<BusinessModuleResolver>();

            //var container = builder.Build();
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
