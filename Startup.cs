using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashPortal.Startup))]
namespace CashPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
