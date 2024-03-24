using System;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using ProCarlosV1.Colleges.Dto;
using ProCarlosV1.Models;

namespace ProCarlosV1.Colleges
{
    public class CollegeAppService : AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>, ICollegeAppService
    {
        public CollegeAppService(IRepository<College, int> repository) : base(repository)
        {

        }
    }

}
