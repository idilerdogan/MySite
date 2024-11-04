using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MySite.Entities.Entities.Concrete;

namespace MySite.Entities.DbContexts
{
    public class SqlDbContext : DbContext
    {

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Activitie> Activities { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experiance> Experiances { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MainMenu> MainMenus { get; set; }


        public SqlDbContext()
        {

        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;Database=MySite;Trusted_Connection=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
