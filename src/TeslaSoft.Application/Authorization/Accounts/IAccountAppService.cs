using System.Threading.Tasks;
using Abp.Application.Services;
using TeslaSoft.Authorization.Accounts.Dto;

namespace TeslaSoft.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
