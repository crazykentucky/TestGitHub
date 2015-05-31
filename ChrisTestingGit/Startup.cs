using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChrisTestingGit.Startup))]
namespace ChrisTestingGit
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
