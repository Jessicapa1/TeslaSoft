using Abp.Application.Services;
using TeslaSoft.MultiTenancy.Dto;

namespace TeslaSoft.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

