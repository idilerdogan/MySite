using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class ActivitieConfig : BaseConfig<Activitie>
    {
        public override void Configure(EntityTypeBuilder<Activitie> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Description).HasMaxLength(1000);
            builder.Property(p => p.Title).HasMaxLength(100);
        }
    }
}
