using System.Threading.Tasks;
using Abp.Application.Services;
using TeslaSoft.Sessions.Dto;

namespace TeslaSoft.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
