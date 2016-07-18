using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudosVendasRoupas.Startup))]
namespace EstudosVendasRoupas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
