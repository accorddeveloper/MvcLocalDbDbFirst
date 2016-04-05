using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectStringDBFirst.Startup))]
namespace ConnectStringDBFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
