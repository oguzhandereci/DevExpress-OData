using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevExpress_OData.Startup))]
namespace DevExpress_OData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
