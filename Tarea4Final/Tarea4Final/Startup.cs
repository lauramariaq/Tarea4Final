using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea4Final.Startup))]
namespace Tarea4Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
