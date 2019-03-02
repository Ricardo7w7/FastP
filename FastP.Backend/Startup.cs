using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FastP.Backend.Startup))]
namespace FastP.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
