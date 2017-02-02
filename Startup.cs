using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetLab3.Startup))]
namespace AspnetLab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
