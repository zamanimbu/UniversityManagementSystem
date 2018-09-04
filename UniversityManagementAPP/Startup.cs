using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityManagementAPP.Startup))]
namespace UniversityManagementAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
