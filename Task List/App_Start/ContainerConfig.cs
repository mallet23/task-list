using System.Web.Http;
using Autofac.Integration.WebApi;
using TaskList.Infrastructure;

namespace Task_List
{
    public static class ContainerConfig
    {
        public static void Register()
        {
            AutofacConfig.Register();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(AutofacConfig.Container);
        }

        public static void DisposeContainer()
        {
            AutofacConfig.Container.Dispose();
        }
    }
}