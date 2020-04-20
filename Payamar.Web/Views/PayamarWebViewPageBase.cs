using Abp.Web.Mvc.Views;

namespace Payamar.Web.Views
{
    public abstract class PayamarWebViewPageBase : PayamarWebViewPageBase<dynamic>
    {

    }

    public abstract class PayamarWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PayamarWebViewPageBase()
        {
            LocalizationSourceName = PayamarConsts.LocalizationSourceName;
        }
    }
}