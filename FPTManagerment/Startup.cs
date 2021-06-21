using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPTManagerment.Startup))]
namespace FPTManagerment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
