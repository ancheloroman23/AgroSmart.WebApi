

using AgroSmart.Core.Application.Enums;
using AgroSmart.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;

namespace AgroSmart.Infrastructure.Identity.Seeds
{
    public static class DefaultClientUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new()
            {
                UserName = "clientuser",
                Email = "clientuser@gmail.com",
                FirstName = "Usuario",
                LastName = "Cliente",
                IdCard = "40226789646",
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
                    await userManager.CreateAsync(defaultUser, "123_Client");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Client.ToString());
                }
            }

        }
    }
}
