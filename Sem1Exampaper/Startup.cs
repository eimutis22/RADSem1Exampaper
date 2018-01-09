using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sem1Exampaper.Startup))]
namespace Sem1Exampaper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
