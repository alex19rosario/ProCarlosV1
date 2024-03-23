using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProCarlosV1.Authorization;

namespace ProCarlosV1
{
    [DependsOn(
        typeof(ProCarlosV1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProCarlosV1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProCarlosV1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProCarlosV1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
