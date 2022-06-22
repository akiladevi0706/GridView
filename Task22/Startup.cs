using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task22.Startup))]
namespace Task22
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
