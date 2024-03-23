using Abp.Application.Services.Dto;

namespace ProCarlosV1.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

