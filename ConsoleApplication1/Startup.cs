using System.Data.Entity;
using System.Web.Http;
using Owin;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using SimpleInjector.Integration.WebApi;

namespace AppIdentityExample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new Container();            
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            container.RegisterSingleton<DbContext>(() => new MyDbContext("ApSec"));
            container.RegisterSingleton<AppUserStore>();
            container.RegisterSingleton<AppUserManager>();

            container.Verify();
            var config = ConfigureWebApi();
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            app.UseWebApi(config);

        }

        private HttpConfiguration ConfigureWebApi()
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            
            return config;
        }


    }
}