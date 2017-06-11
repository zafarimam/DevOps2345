using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication111.Startup))]
namespace WebApplication111
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
