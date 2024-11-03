using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class ProjectConfig : BaseConfig<Project>
    {
        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Title).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(200);
        }
    }
}
