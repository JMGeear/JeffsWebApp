using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JeffsApp.Startup))]
namespace JeffsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
