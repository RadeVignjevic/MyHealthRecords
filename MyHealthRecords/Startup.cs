using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHealthRecords.Startup))]
namespace MyHealthRecords
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
