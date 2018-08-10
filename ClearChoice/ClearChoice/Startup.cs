using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClearChoice.Startup))]
namespace ClearChoice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
