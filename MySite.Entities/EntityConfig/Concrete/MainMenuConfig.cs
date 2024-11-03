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
                MenuName = "Home",
                ControllerName = "Home",
                ActionName = "Index",
                AreaName = "Admin",
                ClassName = "far fa-circle nav-icon",
                CreateDate = DateTime.Now,
                CssName = "",
                RoleId = 1

            },
           new MainMenu
           {
               Id = 2,
               MenuName = "Home",
               ControllerName = "Account",
               ActionName = "Sign In",
               AreaName = "User",
               ClassName = "far fa-circle nav-icon",
               CreateDate = DateTime.Now,
               CssName = "",
               RoleId = 1

           },
            new MainMenu
            {
                Id = 3,
                MenuName = "User",
                ControllerName = "Account",
                ActionName = "Index",
                AreaName = "Admin",
                ClassName = "far fa-circle nav-icon",
                CreateDate = DateTime.Now,
                CssName = "",
                RoleId = 1

            });
        }
    }
}