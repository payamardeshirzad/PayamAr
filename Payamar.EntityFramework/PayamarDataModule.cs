using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Payamar.EntityFramework;

namespace Payamar
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(PayamarCoreModule))]
    public class PayamarDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<PayamarDbContext>(null);
        }
    }
}
