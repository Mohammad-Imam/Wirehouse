using Abp.Authorization;
using Warehouse.Authorization.Roles;
using Warehouse.Authorization.Users;

namespace Warehouse.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
