using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace akbkoleso.Data
{
    public class AppIdentityDbContextSeeder
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser { UserName = "avtogradshina@mail.ru", Email = "avtogradshina@mail.ru" };
            if ((await userManager.FindByEmailAsync("avtogradshina@mail.ru")) == null)
            {
                await userManager.CreateAsync(defaultUser, "Aquafresh$123");
                var roleName = "Admin";
                await roleManager.CreateAsync(new IdentityRole(roleName));
                await userManager.AddToRoleAsync(defaultUser, roleName);
            }
        }
    }
}
