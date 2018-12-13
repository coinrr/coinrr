using System;
using System.Linq;
using System.Threading.Tasks;
using Coinrr.EntityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Coinrr.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;
        public DataSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task SeedSuperUser()
        {
            var roleStore = new RoleStore<IdentityRole>(_context);
            var userStore = new UserStore<ApplicationUser>(_context);

            var user = new ApplicationUser
            {
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var haser = new PasswordHasher<ApplicationUser>();
            var hashedPassword = haser.HashPassword(user, "admin");
            user.PasswordHash = hashedPassword;

            var hasAdminRole = _context.Roles.Any(roles => roles.Name == "Admin");

            if (!hasAdminRole)
            {
                roleStore.CreateAsync(new IdentityRole 
                { 
                    Name="Admin", 
                    NormalizedName="admin" 
                });
            }

            var hasSuperUser = 
                _context.Users.Any(u => u.NormalizedUserName == user.UserName);

            if(!hasSuperUser)
            {
                userStore.CreateAsync(user);
                userStore.AddToRoleAsync(user, "Admin");
            }

            _context.SaveChangesAsync();

            return Task.CompletedTask;
        }

    }
}