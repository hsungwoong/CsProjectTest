using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    //test20150528 sw
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //test 123 
            //test 456
            //added by jsh22//44445555
            //dykim
            //dykim3
        }
    }
}
