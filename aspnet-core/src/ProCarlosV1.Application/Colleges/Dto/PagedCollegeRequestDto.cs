using System;
using Abp.Application.Services.Dto;

namespace ProCarlosV1.Colleges.Dto
{
    public class PagedCollegeResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
