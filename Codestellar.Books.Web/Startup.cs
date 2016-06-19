using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Codestellar.Books.Web.Startup))]
namespace Codestellar.Books.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
