using Microsoft.AspNetCore.Identity;

namespace _1670Project.Models
{
    public class User : IdentityUser
    {
        public string Name {  get; set; }
    }
}
