using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConstructoraUdeC.Startup))]
namespace ConstructoraUdeC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
