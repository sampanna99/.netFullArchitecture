using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetArchitecture.Startup))]
namespace AspNetArchitecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
