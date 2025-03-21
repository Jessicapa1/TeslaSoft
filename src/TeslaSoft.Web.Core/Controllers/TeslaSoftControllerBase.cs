using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TeslaSoft.Controllers
{
    public abstract class TeslaSoftControllerBase: AbpController
    {
        protected TeslaSoftControllerBase()
        {
            LocalizationSourceName = TeslaSoftConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
