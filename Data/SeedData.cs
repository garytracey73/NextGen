using ContactManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {              
                SeedDB(context, "0");
            }
        }        

        public static void SeedDB(ApplicationDbContext context, string adminID)
        {
            context.Category.Add(new Category { Name = "Coding" });
            context.Roles.AddRange(new IdentityRole { Id = "1", Name = "StandardUser" }, new IdentityRole { Id = "2", Name = "Manager" });
            context.Course.AddRange( 
                new Course
                {
                    CategoryId = 1,
                    Name = "Introduction to C#",
                    Description = "C# Training for beginners."
                }, 
                new Course
                {
                    CategoryId = 1,
                    Name = "Introduction to Java",
                    Description = "Java Training for beginners."
                }, 
                new Course
                {
                    CategoryId = 1,
                    Name = "Introduction to PHP",
                    Description = "PHP Training for beginners."
                });

            context.SaveChanges();
        }

    }
}