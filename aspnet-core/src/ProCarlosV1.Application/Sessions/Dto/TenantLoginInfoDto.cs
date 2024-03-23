using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProCarlosV1.MultiTenancy;

namespace ProCarlosV1.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
