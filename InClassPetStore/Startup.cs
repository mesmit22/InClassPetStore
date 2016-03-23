using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassPetStore.Startup))]
namespace InClassPetStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
