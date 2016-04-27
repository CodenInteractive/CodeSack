using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeSack.Startup))]
namespace CodeSack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
