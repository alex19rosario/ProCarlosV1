using Abp.Authorization;
using ProCarlosV1.Authorization.Roles;
using ProCarlosV1.Authorization.Users;

namespace ProCarlosV1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
