using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnAspNetMVC.Startup))]
namespace LearnAspNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
