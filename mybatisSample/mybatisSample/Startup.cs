using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mybatisSample.Startup))]
namespace mybatisSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
