using Abp.Application.Services;

namespace Payamar
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PayamarAppServiceBase : ApplicationService
    {
        protected PayamarAppServiceBase()
        {
            LocalizationSourceName = PayamarConsts.LocalizationSourceName;
        }
    }
}