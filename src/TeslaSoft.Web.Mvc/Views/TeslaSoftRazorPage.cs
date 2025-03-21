using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TeslaSoft.Web.Views
{
    public abstract class TeslaSoftRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TeslaSoftRazorPage()
        {
            LocalizationSourceName = TeslaSoftConsts.LocalizationSourceName;
        }
    }
}
