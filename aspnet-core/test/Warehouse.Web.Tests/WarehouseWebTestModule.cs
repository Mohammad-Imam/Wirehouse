using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Warehouse.EntityFrameworkCore;
using Warehouse.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Warehouse.Web.Tests
{
    [DependsOn(
        typeof(WarehouseWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class WarehouseWebTestModule : AbpModule
    {
        public WarehouseWebTestModule(WarehouseEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WarehouseWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(WarehouseWebMvcModule).Assembly);
        }
    }
}