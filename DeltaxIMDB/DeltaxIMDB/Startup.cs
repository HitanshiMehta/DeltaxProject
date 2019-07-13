using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeltaxIMDB.Startup))]
namespace DeltaxIMDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
