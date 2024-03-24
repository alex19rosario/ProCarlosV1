using System;
using Abp.Application.Services;
using ProCarlosV1.Colleges.Dto;
using ProCarlosV1.Students.Dto;

namespace ProCarlosV1.Colleges
{
    public interface ICollegeAppService : IAsyncCrudAppService<CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>
    {

    }
}
