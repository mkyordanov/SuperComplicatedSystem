using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperComplicatedSystem.Startup))]
namespace SuperComplicatedSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
