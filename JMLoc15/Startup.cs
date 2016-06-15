using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMLoc15.Startup))]
namespace JMLoc15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
