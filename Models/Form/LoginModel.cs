using System.ComponentModel.DataAnnotations;

namespace _1670Project.Models.Form
{
    public class LoginModel
    {
            [Required]
            public string? Username { get; set; }

            [Required]
            public string? Password { get; set; }

    }
}
