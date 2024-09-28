

using AgroSmart.Core.Application.Enums;
using AgroSmart.Infraestructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace AgroSmart.Infraestructure.Identity.Seeds
{
    public class DefaultAdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new()
            {
                UserName = "adminuser",
                Email = "adminuser@gmail.com",
                FirstName = "User",
                LastName = "Admin",
                IdCard = "40226789647",
                ImageUser = "",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                IsActive = true,
                
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123_Admin");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                }
            }

        }
    }
}
