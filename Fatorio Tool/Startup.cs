using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fatorio_Tool.Startup))]
namespace Fatorio_Tool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
