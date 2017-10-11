using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityProj.Startup))]
namespace CommunityProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
