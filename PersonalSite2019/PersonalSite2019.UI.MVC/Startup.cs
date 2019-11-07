using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalSite2019.UI.MVC.Startup))]
namespace PersonalSite2019.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
