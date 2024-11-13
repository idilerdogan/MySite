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


            builder.HasData(new Activitie() { Id = 5, CreateDate = DateTime.Now, DateBegining = new DateTime(2015, 9, 1), DateEnding = new DateTime(2021, 9, 1), Title = "Sabanci University Drama Club", Description = "Member, director and actress" });
            builder.HasData(new Activitie() { Id = 4, CreateDate = DateTime.Now, DateBegining = new DateTime(2017, 9, 1), DateEnding = new DateTime(2018, 9, 1), Title = "Sabanci University Drama Club", Description = "Co- President" });
            builder.HasData(new Activitie() { Id = 3, CreateDate = DateTime.Now, DateBegining = new DateTime(2015, 9, 1), DateEnding = new DateTime(2018, 9, 1), Title = "Sabanci University Offtown Committee", Description = "Member, media coordinator and media, concert, sponsorship contractor" });
            builder.HasData(new Activitie() { Id = 2, CreateDate = DateTime.Now, DateBegining = new DateTime(2017, 9, 1), DateEnding = new DateTime(2018, 9, 1), Title = "\"Üniversitelerarası Tiyatro Festivali\"", Description = "Organizing a nation-wide theatre festival" });
            builder.HasData(new Activitie() { Id = 1, CreateDate = DateTime.Now, DateBegining = new DateTime(2015, 9, 1), DateEnding = new DateTime(2016, 5, 1), Title = "Sabanci University \"SURK\" Robotics Club", Description = "Member" });


        }
    }
}
