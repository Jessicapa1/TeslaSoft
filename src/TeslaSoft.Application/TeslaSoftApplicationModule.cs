using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeslaSoft.Authorization;

namespace TeslaSoft
{
    [DependsOn(
        typeof(TeslaSoftCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TeslaSoftApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TeslaSoftAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TeslaSoftApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
