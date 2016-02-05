using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEssentialsHw.Startup))]
namespace MvcEssentialsHw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
