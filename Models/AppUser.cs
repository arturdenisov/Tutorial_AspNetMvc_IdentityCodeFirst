using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_AspNetMvc_IdentityCodeFirst.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public override string Email { get; set; }
    }
}
