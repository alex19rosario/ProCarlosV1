using System.Threading.Tasks;
using Abp.Application.Services;
using ProCarlosV1.Sessions.Dto;

namespace ProCarlosV1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
