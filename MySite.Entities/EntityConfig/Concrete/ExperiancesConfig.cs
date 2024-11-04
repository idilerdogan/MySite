using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class ExperiancesConfig : BaseConfig<Experiance>
    {
        public override void Configure(EntityTypeBuilder<Experiance> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.ExTitle).HasMaxLength(50);
            builder.Property(p => p.ExDescription).HasMaxLength(1000);
            builder.Property(p => p.ExPlace).HasMaxLength(30);
        }
    }
}

