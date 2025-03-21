using Abp.Authorization;
using TeslaSoft.Authorization.Roles;
using TeslaSoft.Authorization.Users;

namespace TeslaSoft.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
