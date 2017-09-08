using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Products2.Backend.Startup))]
namespace Products2.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
