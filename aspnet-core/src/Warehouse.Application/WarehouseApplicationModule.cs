using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Warehouse.Authorization;

namespace Warehouse
{
    [DependsOn(
        typeof(WarehouseCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WarehouseApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WarehouseAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WarehouseApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
