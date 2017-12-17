using System;
using Autofac;
using Autofac.Integration.WebApi;
using TaskList.Controllers;
using TaskList.Repositories;
using TaskList.Services;

namespace TaskList.Infrastructure
{
    public static class AutofacConfig
    {
        public static IContainer Container { get; private set; }

        public static void Register()
        {
            Register(null);
        }

        internal static void Register(Action<ContainerBuilder> additionalBuild)
        {
            Container = CreateContainer(additionalBuild);
        }

        internal static IContainer CreateContainer()
        {
            return CreateContainer(null);
        }

        internal static IContainer CreateContainer(Action<ContainerBuilder> additionalBuild)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(typeof(TasksController).Assembly);
            RegisterComponents(builder);
            additionalBuild?.Invoke(builder);
            return builder.Build();
        }

        private static void RegisterComponents(ContainerBuilder builder)
        {
            var servicesAssembly = typeof(TaskService).Assembly;
            builder.RegisterAssemblyTypes(servicesAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterType<Repository>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}