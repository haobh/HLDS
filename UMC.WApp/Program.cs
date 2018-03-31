using System;
using System.Windows.Forms;
using UMC.Data.Repositories;
using Microsoft.Practices.Unity;
using UMC.Data.Infrastructure;
using UMC.Data;
using UMC.Service;
using SimpleInjector.Extensions.LifetimeScoping;
using SimpleInjector;
using Autofac;
using TeduShop.Web.Mappings;

namespace UMC.WApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var container = new UnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //UnityConfig.RegisterTypes(container);
            ConfigAutofac();
            AutoMapperConfiguration.Configure();
            Application.Run(new frmMain());
        }

        private static void ConfigAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<UMCDbContext>().AsSelf().InstancePerRequest();

            //Repositories
            builder.RegisterAssemblyTypes(typeof(ShiftRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            // Services
            builder.RegisterAssemblyTypes(typeof(ShiftService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            var container = builder.Build();

        }

    }
}
