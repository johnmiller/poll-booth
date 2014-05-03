using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PollBooth.Web.Startup))]
namespace PollBooth.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
