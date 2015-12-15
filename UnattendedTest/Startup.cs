using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnattendedTest.Startup))]
namespace UnattendedTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
