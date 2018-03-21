using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectOnePlace.Startup))]
namespace ProjectOnePlace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
