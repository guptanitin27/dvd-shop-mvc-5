using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVD_Shop.Startup))]
namespace DVD_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
