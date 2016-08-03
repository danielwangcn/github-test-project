using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git_test_project.Startup))]
namespace git_test_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
