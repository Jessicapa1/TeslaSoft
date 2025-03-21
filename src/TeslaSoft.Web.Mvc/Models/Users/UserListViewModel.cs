using System.Collections.Generic;
using TeslaSoft.Roles.Dto;

namespace TeslaSoft.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
