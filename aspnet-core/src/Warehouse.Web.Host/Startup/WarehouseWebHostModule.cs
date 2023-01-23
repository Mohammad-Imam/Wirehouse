using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Warehouse.Configuration;

namespace Warehouse.Web.Host.Startup
{
    [DependsOn(
       typeof(WarehouseWebCoreModule))]
    public class WarehouseWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WarehouseWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WarehouseWebHostModule).GetAssembly());
        }
    }
}
