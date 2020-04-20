using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Payamar
{
    [DependsOn(typeof(AbpWebApiModule), typeof(PayamarApplicationModule))]
    public class PayamarWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(PayamarApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
