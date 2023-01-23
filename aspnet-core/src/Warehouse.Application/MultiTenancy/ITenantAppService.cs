using Abp.Application.Services;
using Warehouse.MultiTenancy.Dto;

namespace Warehouse.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

