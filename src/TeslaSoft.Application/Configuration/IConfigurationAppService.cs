using System.Threading.Tasks;
using TeslaSoft.Configuration.Dto;

namespace TeslaSoft.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
