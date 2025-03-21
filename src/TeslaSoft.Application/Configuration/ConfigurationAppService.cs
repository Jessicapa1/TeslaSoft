using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TeslaSoft.Configuration.Dto;

namespace TeslaSoft.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TeslaSoftAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
