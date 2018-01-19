using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RollBar.Startup))]
namespace RollBar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
