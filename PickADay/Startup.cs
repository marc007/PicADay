using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PickADay.Startup))]
namespace PickADay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
