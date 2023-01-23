using System.ComponentModel.DataAnnotations;

namespace Warehouse.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}