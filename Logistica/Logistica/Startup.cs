using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Logistica.Startup))]
namespace Logistica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
