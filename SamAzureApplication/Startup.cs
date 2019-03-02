using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamAzureApplication.Startup))]
namespace SamAzureApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
