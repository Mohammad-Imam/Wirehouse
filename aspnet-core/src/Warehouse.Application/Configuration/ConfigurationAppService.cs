using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Warehouse.Configuration.Dto;

namespace Warehouse.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WarehouseAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
