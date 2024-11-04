using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Description { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public List<Role>? Roles { get; set; }

        public List<Achievement>? Achievements { get; set; } = new List<Achievement>();
        public List<Activitie>? Activities { get; set; } = new List<Activitie>();
        public List<Education>? Education { get; set; } = new List<Education>();
        public List<Experience>? Experiances { get; set; } = new List<Experience>();
        public List<Language>? Languages { get; set; } = new List<Language>();
        public List<Project>? Projects { get; set; } = new List<Project>();
        public List<Skill>? Skills { get; set; } = new List<Skill>();
        public List<SocialMedia>? SocialMedias { get; set; } = new List<SocialMedia>();








    }
}
