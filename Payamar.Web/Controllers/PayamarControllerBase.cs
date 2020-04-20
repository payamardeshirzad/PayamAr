using Abp.Web.Mvc.Controllers;

namespace Payamar.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class PayamarControllerBase : AbpController
    {
        protected PayamarControllerBase()
        {
            LocalizationSourceName = PayamarConsts.LocalizationSourceName;
        }
    }
}