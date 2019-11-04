using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WinnersProject.Startup))]
namespace WinnersProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
