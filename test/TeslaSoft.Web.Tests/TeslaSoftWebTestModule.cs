using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TeslaSoft.EntityFrameworkCore;
using TeslaSoft.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TeslaSoft.Web.Tests
{
    [DependsOn(
        typeof(TeslaSoftWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TeslaSoftWebTestModule : AbpModule
    {
        public TeslaSoftWebTestModule(TeslaSoftEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TeslaSoftWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TeslaSoftWebMvcModule).Assembly);
        }
    }
}