using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchol.Startup))]
namespace BigSchol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
