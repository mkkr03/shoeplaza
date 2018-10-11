using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoeplaza.Startup))]
namespace shoeplaza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
