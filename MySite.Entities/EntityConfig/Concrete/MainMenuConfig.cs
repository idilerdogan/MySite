using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class MainMenuConfig : BaseConfig<MainMenu>
    {
        public override void Configure(EntityTypeBuilder<MainMenu> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MenuName).HasMaxLength(50);
            builder.Property(p => p.ActionName).HasMaxLength(50);
            builder.Property(p => p.ControllerName).HasMaxLength(50);
            builder.Property(p => p.AreaName).HasMaxLength(50);
            builder.Property(p => p.CssName).HasMaxLength(500);
            builder.Property(p => p.IconName).HasMaxLength(500);

            builder.HasData(new MainMenu
            {
                Id = 1,
                MenuName = "About",
                ControllerName = "Home",
                ActionName = "About",
                // AreaName = "Admin",
                ClassName = "far fa-circle nav-icon",
                CreateDate = DateTime.Now,
                CssName = "",
                RoleId = 1

            },
             new MainMenu
             {
                 Id = 2,
                 MenuName = "Education",
                 ControllerName = "Home",
                 ActionName = "Education",
                 // AreaName = "Admin",
                 ClassName = "far fa-circle nav-icon",
                 CreateDate = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
           new MainMenu
           {
               Id = 3,
               MenuName = "Experience",
               ControllerName = "Home",
               ActionName = "Experience",
               // AreaName = "User",
               ClassName = "far fa-circle nav-icon",
               CreateDate = DateTime.Now,
               CssName = "",
               RoleId = 1

           },
             new MainMenu
             {
                 Id = 4,
                 MenuName = "Projects",
                 ControllerName = "Home",
                 ActionName = "Project",
                 //AreaName = "Admin",
                 ClassName = "far fa-circle nav-icon",
                 CreateDate = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = 5,
                 MenuName = "Skills",
                 ControllerName = "Home",
                 ActionName = "Skill",
                 // AreaName = "Admin",
                 ClassName = "far fa-circle nav-icon",
                 CreateDate = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = 6,
                 MenuName = "Achievements",
                 ControllerName = "Home",
                 ActionName = "Achievement",
                 // AreaName = "Admin",
                 ClassName = "far fa-circle nav-icon",
                 CreateDate = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
             new MainMenu
             {
                 Id = 7,
                 MenuName = "Activities",
                 ControllerName = "Home",
                 ActionName = "Activitie",
                 //AreaName = "Admin",
                 ClassName = "far fa-circle nav-icon",
                 CreateDate = DateTime.Now,
                 CssName = "",
                 RoleId = 1

             },
              new MainMenu
              {
                  Id = 8,
                  MenuName = "Languages",
                  ControllerName = "Home",
                  ActionName = "Language",
                  // AreaName = "Admin",
                  ClassName = "far fa-circle nav-icon",
                  CreateDate = DateTime.Now,
                  CssName = "",
                  RoleId = 1

              });
        }
    }
}