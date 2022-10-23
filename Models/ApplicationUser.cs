using Microsoft.AspNetCore.Identity;

namespace NotUseAuto.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Image { get;set; }
    }
}
