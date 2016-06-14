using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcBase.Startup))]
namespace MvcBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
