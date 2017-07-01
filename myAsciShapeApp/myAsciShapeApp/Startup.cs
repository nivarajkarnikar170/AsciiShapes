using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myAsciShapeApp.Startup))]
namespace myAsciShapeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
