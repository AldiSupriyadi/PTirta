using Microsoft.AspNetCore.Identity;

namespace PTirta.Models
{
    public class Users : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
