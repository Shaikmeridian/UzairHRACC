using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRACCPortal.Startup))]
namespace HRACCPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
