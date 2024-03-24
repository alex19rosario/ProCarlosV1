using Abp.Application.Services;
using ProCarlosV1.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCarlosV1.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {

    }
}
