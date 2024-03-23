using System.ComponentModel.DataAnnotations;

namespace ProCarlosV1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}