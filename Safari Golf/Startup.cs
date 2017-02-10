using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafariGolf.Startup))]
namespace SafariGolf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
