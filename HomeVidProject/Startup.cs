using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeVidProject.Startup))]
namespace HomeVidProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
