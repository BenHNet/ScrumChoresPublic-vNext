using ScrumChores.Model.Entities;
using Microsoft.Data.Entity;

namespace ScrumChores.Business.Context
{
    public class ScrumChoresDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptions builder)
        {
            builder.UseSqlServer();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<SprintTask> Tasks { get; set; } 
    }
}
