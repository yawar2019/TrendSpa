using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExceptionalHandler2.Startup))]
namespace ExceptionalHandler2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
