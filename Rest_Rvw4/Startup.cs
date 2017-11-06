using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rest_Rvw4.Startup))]
namespace Rest_Rvw4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
