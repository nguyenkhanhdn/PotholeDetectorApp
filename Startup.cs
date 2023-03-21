using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PotholeDetectorApp.Startup))]
namespace PotholeDetectorApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
