using System.Threading.Tasks;
using ProCarlosV1.Configuration.Dto;

namespace ProCarlosV1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
