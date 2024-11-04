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
            builder.Property(p => p.Description).HasMaxLength(1000);


            builder.HasData(new Achievement() { Id = 1, CreateDate = DateTime.Now, AcDate= new DateOnly(2020, 2,1), Description= "Decleration of honor in dean’s honor list for maintaining a high GPA" });
            builder.HasData(new Achievement() { Id = 2, CreateDate = DateTime.Now, AcDate = new DateOnly(2016,1, 1), Description = "Sabanci University Extracurricular Activities Award Awarded for theatre tours around the country and abroad / Organizing the Offtown Festival with\r\nthe Offtown Committee" });


        }
    }
}
