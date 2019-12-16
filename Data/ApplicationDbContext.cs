using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactManager.Models.Course> Course { get; set; }
        public DbSet<ContactManager.Models.CourseInstance> CourseInstance { get; set; }
        public DbSet<ContactManager.Models.Category> Category { get; set; }
    }
}
