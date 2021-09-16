using Microsoft.AspNetCore.Identity;

namespace akbkoleso.Data
{ 
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
