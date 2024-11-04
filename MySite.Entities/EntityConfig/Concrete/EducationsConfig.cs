using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class EducationsConfig : BaseConfig<Education>
    {
        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Description).HasMaxLength(1000);
            builder.Property(p => p.ScName).HasMaxLength(50);
            builder.Property(p => p.Degree).HasMaxLength(5);
        }
    }
}
