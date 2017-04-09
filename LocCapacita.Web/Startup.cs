using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocCapacita.Web.Startup))]
namespace LocCapacita.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
