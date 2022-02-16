using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolManagementViewSite.Startup))]
namespace SchoolManagementViewSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
