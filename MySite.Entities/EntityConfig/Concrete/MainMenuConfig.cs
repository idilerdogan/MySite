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
            builder.Property(p => p.IConName).HasMaxLength(500);

        }
    }
}