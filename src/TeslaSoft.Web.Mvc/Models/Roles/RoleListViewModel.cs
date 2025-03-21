using System.Collections.Generic;
using TeslaSoft.Roles.Dto;

namespace TeslaSoft.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
