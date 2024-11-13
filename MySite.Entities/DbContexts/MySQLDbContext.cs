using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MySite.Entities.Entities.Concrete;

namespace MySite.Entities.DbContexts
{
    public class MySQLDbContext : DbContext
    {

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Activitie> Activities { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MainMenu> MainMenus { get; set; }


        public MySQLDbContext()
        {

        }

        public MySQLDbContext(DbContextOptions<MySQLDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=host.docker.internal;Port=9999;Database=mysite;Uid=root;password=qweasd");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
