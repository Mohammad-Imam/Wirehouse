using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Warehouse.Controllers
{
    public abstract class WarehouseControllerBase: AbpController
    {
        protected WarehouseControllerBase()
        {
            LocalizationSourceName = WarehouseConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
