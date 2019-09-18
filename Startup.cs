using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnnieMoreno_MIS4200.Startup))]
namespace AnnieMoreno_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
