using Abp.Application.Services;
using ProCarlosV1.MultiTenancy.Dto;

namespace ProCarlosV1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

