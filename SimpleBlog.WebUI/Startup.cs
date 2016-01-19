using Microsoft.Owin;
using Owin;
using SimpleBlog.WebUI;

[assembly: OwinStartup(typeof(Startup))]
namespace SimpleBlog.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}