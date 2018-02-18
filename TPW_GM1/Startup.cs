using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPW_GM1.Startup))]
namespace TPW_GM1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
