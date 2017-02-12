using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Invitation.Startup))]
namespace Invitation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
