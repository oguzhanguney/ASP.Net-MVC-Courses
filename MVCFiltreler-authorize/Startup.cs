using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFiltreler_authorize.Startup))]
namespace MVCFiltreler_authorize
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
