using System;
using System.Web.Http;

namespace Task_List
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            ContainerConfig.Register();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            ContainerConfig.DisposeContainer();
        }
    }
}