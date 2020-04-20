using System.Reflection;
using Abp.Modules;

namespace Payamar
{
    [DependsOn(typeof(PayamarCoreModule))]
    public class PayamarApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
