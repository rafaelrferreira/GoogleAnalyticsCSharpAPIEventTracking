using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleAnalyticsCSharpAPIET.Startup))]
namespace GoogleAnalyticsCSharpAPIET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
