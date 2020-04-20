using System.Reflection;
using Abp.Modules;

namespace Payamar
{
    public class PayamarCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
