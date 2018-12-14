using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP229_FinalProject.Startup))]
namespace COMP229_FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
