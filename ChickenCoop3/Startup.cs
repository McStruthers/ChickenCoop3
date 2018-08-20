using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChickenCoop3.Startup))]
namespace ChickenCoop3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
