using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClusterCart.Startup))]
namespace ClusterCart
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
