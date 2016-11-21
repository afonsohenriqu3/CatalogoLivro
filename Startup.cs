using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatalogoLivro.Startup))]
namespace CatalogoLivro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
