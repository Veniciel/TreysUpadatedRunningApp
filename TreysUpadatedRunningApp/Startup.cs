using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreysUpadatedRunningApp.Startup))]
namespace TreysUpadatedRunningApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
