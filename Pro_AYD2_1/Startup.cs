using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pro_AYD2_1.Startup))]
namespace Pro_AYD2_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
