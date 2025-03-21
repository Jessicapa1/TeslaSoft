using Abp.AspNetCore.Mvc.ViewComponents;

namespace TeslaSoft.Web.Views
{
    public abstract class TeslaSoftViewComponent : AbpViewComponent
    {
        protected TeslaSoftViewComponent()
        {
            LocalizationSourceName = TeslaSoftConsts.LocalizationSourceName;
        }
    }
}
