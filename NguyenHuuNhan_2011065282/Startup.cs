using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHuuNhan_2011065282.Startup))]
namespace NguyenHuuNhan_2011065282
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
