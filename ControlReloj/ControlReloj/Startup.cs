using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlReloj.Startup))]
namespace ControlReloj
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
