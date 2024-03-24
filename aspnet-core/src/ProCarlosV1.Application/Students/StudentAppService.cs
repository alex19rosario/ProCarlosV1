using Abp.Application.Services;
using Abp.Domain.Repositories;
using ProCarlosV1.Models;
using ProCarlosV1.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCarlosV1.Students
{
    // [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService
        (
            IRepository<Student, int> repository
        )
        : base(repository)
        {

        }

    }
}
