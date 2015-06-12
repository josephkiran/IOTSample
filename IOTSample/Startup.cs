using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IOTSample.Startup))]
namespace IOTSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
