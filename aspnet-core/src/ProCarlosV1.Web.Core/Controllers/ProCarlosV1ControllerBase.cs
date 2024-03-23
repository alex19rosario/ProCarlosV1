using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProCarlosV1.Controllers
{
    public abstract class ProCarlosV1ControllerBase: AbpController
    {
        protected ProCarlosV1ControllerBase()
        {
            LocalizationSourceName = ProCarlosV1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
