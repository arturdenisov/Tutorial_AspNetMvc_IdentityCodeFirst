using Tutorial_AspNetMvc_IdentityCodeFirst.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tutorial_AspNetMvc_IdentityCodeFirst
{
    public class CustomDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }


        public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
        {
#if ZEROMODE
            //(1)Ensures that the database for the context does not exist.
            //If it does not exist, no action is taken.
            //If it does exist then the database is deleted.
            Database.EnsureDeleted();

            //(2) Ensures that the database for the context exists.
            //If it exists, no action is taken.
            //If it does not exist then the database and all its schema are created.
            Database.EnsureCreated();
#endif
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=TestPostgreDB;Username=postgres;Password=7891");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
