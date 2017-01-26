using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Safari_Golf.Startup))]
namespace Safari_Golf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
