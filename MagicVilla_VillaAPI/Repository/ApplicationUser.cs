using Microsoft.AspNetCore.Identity;

namespace MagicVilla_VillaAPI.Repository
{
    public class ApplicationUser : IdentityUser
    {
        public string Name {  get; set; }
    }
}
