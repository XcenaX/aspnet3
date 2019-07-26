using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using WebApplication2.App_Start;
using WebApplication2.Models;

[assembly: OwinStartup(typeof(Startup))]
namespace WebApplication2.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            builder.CreatePerOwinContext(AppContext.Create);
            builder.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            builder.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}