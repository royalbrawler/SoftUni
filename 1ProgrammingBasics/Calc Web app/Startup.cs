using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calc_Web_app.Startup))]
namespace Calc_Web_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
