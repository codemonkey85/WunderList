using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WunderListSample.Startup))]
namespace WunderListSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
