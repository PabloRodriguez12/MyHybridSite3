using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHybridSite3.Startup))]
namespace MyHybridSite3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
