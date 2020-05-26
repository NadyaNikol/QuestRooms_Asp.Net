using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Repositories;


namespace WebApplication4.Utils
{
    public class AutofacRegistraion
    {
       public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder
                .RegisterType<QuestRoomRepository>()
                .As<IRepository<QuestRoom>>().SingleInstance();

            builder
                .RegisterType<TelephoneRepository>()
                .As<IRepository<Telephone>>().SingleInstance();

            builder
                .RegisterType<EFUnitOfWork>()
                .As<IUnitOfWork>().SingleInstance();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}