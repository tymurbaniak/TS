using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TS.Startup))]
namespace TS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
