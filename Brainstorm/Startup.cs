using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brainstorm.Startup))]
namespace Brainstorm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
