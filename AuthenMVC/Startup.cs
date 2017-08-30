using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenMVC.Startup))]
namespace AuthenMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
