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


            builder.HasData(new Education() { Id = 2, CreateDate = DateTime.Now, ScBeginning = new DateTime(2015, 9, 1), ScEndning = new DateTime(2021, 2, 4), ScName = "Sabancı University", Description = "BSC Mechatronics Engineering", Degree = "2,91" });
            builder.HasData(new Education() { Id = 1, CreateDate = DateTime.Now, ScBeginning = new DateTime(2010, 9, 1), ScEndning = new DateTime(2015, 6, 1), ScName = "Karşıyaka Anatolian High School", Description = "", Degree = "89.90" });


        }
    }
}
