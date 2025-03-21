using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeslaSoft.Configuration;

namespace TeslaSoft.Web.Host.Startup
{
    [DependsOn(
       typeof(TeslaSoftWebCoreModule))]
    public class TeslaSoftWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TeslaSoftWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TeslaSoftWebHostModule).GetAssembly());
        }
    }
}
