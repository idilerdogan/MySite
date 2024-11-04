using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class ExperiencesConfig : BaseConfig<Experience>
    {
        public override void Configure(EntityTypeBuilder<Experience> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.ExTitle).HasMaxLength(50);
            builder.Property(p => p.ExDescription).HasMaxLength(1000);
            builder.Property(p => p.ExPlace).HasMaxLength(100);


            builder.HasData(new Experience() { Id = 6, CreateDate = DateTime.Now, ExBeginning = new DateOnly(2019, 7, 1), ExEnding = new DateOnly(2019, 8, 31), ExTitle = "Internship", ExPlace = "Kordsa", ExDescription = "Assembled and adapted PLC to old German Ring Twisted Machines" });
            builder.HasData(new Experience() { Id = 5, CreateDate = DateTime.Now, ExBeginning = new DateOnly(2018, 6, 1), ExEnding = new DateOnly(2019, 3, 31), ExTitle = "Introduction Team Member", ExPlace = "Sabanci University", ExDescription = "Provided introductory campus tour for visitors. Gave additional information though phone calls and the information stand" });
            builder.HasData(new Experience() { Id = 4, CreateDate = DateTime.Now, ExBeginning = new DateOnly(2017, 7, 1), ExEnding = new DateOnly(2017, 8, 31), ExTitle = "Creator Drama & Acting Instructor", ExPlace = "Sabanci University", ExDescription = "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School" });
            builder.HasData(new Experience() { Id = 3, CreateDate = DateTime.Now, ExBeginning = new DateOnly(2018, 7, 1), ExEnding = new DateOnly(2018, 8, 31), ExTitle = "Creator Drama & Acting Instructor", ExPlace = "Sabanci University", ExDescription = "Planned drama class curriculum Conducted drama and acting class for in the scope of Highschool Summer School" });
            builder.HasData(new Experience() { Id = 2, CreateDate = DateTime.Now, ExBeginning = new DateOnly(2015, 6, 1), ExEnding = new DateOnly(2016, 8, 31), ExTitle = "Part-Time Assistant in Administration", ExPlace = "Efesus Outlet Center", ExDescription = "Attended meetings with the manager of the center Provided correlation in mailing system" });
            builder.HasData(new Experience() { Id = 1, CreateDate = DateTime.Now, ExBeginning = new DateOnly(2011, 6, 1), ExEnding = new DateOnly(2011, 8, 31), ExTitle = "Asistant", ExPlace = "Ibrahim Ozturk Independent Accountant And Tax Professional", ExDescription = "Kept record of the balance sheet by using Excel efficiently Provided report of the profit and loss account statement" });



        }
    }
}

