using System.ComponentModel.DataAnnotations;

namespace TeslaSoft.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}