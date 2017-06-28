using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomateMe.Startup))]
namespace AutomateMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
