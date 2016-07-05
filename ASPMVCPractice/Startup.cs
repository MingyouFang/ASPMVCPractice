using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPMVCPractice.Startup))]
namespace ASPMVCPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
