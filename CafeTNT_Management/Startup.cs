using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CafeTNT_Management.Startup))]
namespace CafeTNT_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
