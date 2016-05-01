using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetFrameworkWebApp.Startup))]
namespace NetFrameworkWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
