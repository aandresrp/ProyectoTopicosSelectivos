using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoSelectos.Startup))]
namespace ProyectoSelectos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
