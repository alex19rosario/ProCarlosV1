using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProCarlosV1.Configuration.Dto;

namespace ProCarlosV1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProCarlosV1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
