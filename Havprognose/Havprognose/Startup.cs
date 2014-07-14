using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Havprognose.Startup))]
namespace Havprognose
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
