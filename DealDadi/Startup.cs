using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealDadi.Startup))]
namespace DealDadi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
