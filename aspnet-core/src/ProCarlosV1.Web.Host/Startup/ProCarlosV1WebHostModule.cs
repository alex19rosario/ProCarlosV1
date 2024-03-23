using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProCarlosV1.Configuration;

namespace ProCarlosV1.Web.Host.Startup
{
    [DependsOn(
       typeof(ProCarlosV1WebCoreModule))]
    public class ProCarlosV1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProCarlosV1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProCarlosV1WebHostModule).GetAssembly());
        }
    }
}
