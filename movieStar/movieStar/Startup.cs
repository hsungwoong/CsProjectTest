using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movieStar.Startup))]
namespace movieStar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
