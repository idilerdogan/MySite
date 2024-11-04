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


            builder.HasData(new Achievement() { Id = 7, CreateDate = DateTime.Now, AcDate = new DateOnly(2020, 2, 1), Description = "Decleration of honor in dean’s honor list for maintaining a high GPA" });
            builder.HasData(new Achievement() { Id = 6, CreateDate = DateTime.Now, AcDate = new DateOnly(2016, 1, 1), Description = "Sabanci University Extracurricular Activities Award Awarded for theatre tours around the country and abroad / Organizing the Offtown Festival with\r\nthe Offtown Committee" });
            builder.HasData(new Achievement() { Id = 5, CreateDate = DateTime.Now, AcDate = new DateOnly(2017, 2, 1), Description = "Decleration of honor in dean’s honor list for maintaining a high GPA" });
            builder.HasData(new Achievement() { Id = 4, CreateDate = DateTime.Now, AcDate = new DateOnly(2016, 9, 1), Description = "Decleration of high honor in dean’s honor list for maintaining a high GPA" });
            builder.HasData(new Achievement() { Id = 3, CreateDate = DateTime.Now, AcDate = new DateOnly(2015, 1, 17), Description = "Turkish Championship Bilecik Youth Group First Place (Türkiye Şampiyonası Bilecik Basketbol Gençler Grup Birinci) with Karşıyaka Anatolian High School Basketball Team" });
            builder.HasData(new Achievement() { Id = 2, CreateDate = DateTime.Now, AcDate = new DateOnly(2015, 2, 1), Description = "2014 - 2015 Basketball Young Girls Province Cup Third Place (2014 - 2015 Basketbol Genç Kızlar İl (İzmir) Kupası) with Karşıyaka Anatolian High school Basketball Team" });
            builder.HasData(new Achievement() { Id = 1, CreateDate = DateTime.Now, AcDate = new DateOnly(2013, 2, 1), Description = "Basketball Distict Cup First Place (Basketbol İlçe Kaymakamlik Kupası) with Karşıyaka Anatolian High school Basketball Team" });






        }
    }
}
