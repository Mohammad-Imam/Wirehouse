using System.Threading.Tasks;
using Warehouse.Configuration.Dto;

namespace Warehouse.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
