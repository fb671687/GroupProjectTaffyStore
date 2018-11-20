using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroupProjectTaffyStore.Startup))]
namespace GroupProjectTaffyStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
