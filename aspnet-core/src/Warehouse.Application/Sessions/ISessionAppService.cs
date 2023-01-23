using System.Threading.Tasks;
using Abp.Application.Services;
using Warehouse.Sessions.Dto;

namespace Warehouse.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
