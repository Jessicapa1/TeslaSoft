using System.Collections.Generic;
using TeslaSoft.Roles.Dto;

namespace TeslaSoft.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}