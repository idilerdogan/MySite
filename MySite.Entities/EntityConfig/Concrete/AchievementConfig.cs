using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class AchievementConfig : BaseConfig<Achievement>
    {
        public override void Configure(EntityTypeBuilder<Achievement> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Description).HasMaxLength(100);

        }
    }
}
