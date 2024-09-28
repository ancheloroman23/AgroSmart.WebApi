
using Microsoft.AspNetCore.Identity;

namespace AgroSmart.Infraestructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCard { get; set; }
        public string? PhoneNumber {  get; set; }
        public string ImageUser { get; set; }
        public bool IsActive { get; set; }
    }
}
