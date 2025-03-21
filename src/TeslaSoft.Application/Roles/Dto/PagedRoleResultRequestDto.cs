using Abp.Application.Services.Dto;

namespace TeslaSoft.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

