﻿using Abp.AutoMapper;
using TeslaSoft.Sessions.Dto;

namespace TeslaSoft.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
