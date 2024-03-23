using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProCarlosV1.EntityFrameworkCore;
using ProCarlosV1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ProCarlosV1.Web.Tests
{
    [DependsOn(
        typeof(ProCarlosV1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ProCarlosV1WebTestModule : AbpModule
    {
        public ProCarlosV1WebTestModule(ProCarlosV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProCarlosV1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ProCarlosV1WebMvcModule).Assembly);
        }
    }
}