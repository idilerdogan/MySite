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
            builder.Property(p => p.Description).HasMaxLength(2000);



            builder.HasData(new Project() { Id = 8, CreateDate = DateTime.Now, Date = new DateTime(2021, 9, 1), Title = "Lower-Limb Exoskeleton with EEG/Team EXONIX", Description = "Designed a lower-limb exoskeleton and improved the prototypes for the walk and rehabilitation of the paraplegic people. Joined the Biotechnology Innovation Competition with this project in Teknofest 2021" });
            builder.HasData(new Project() { Id = 7, CreateDate = DateTime.Now, Date = new DateTime(2021, 2, 4), Title = "Bilateral Steering for a Mobile Robot", Description = "Designed and simulated a wheeled robot system of 2 DOF using MATLAB Simulink & Solidworks that moves and recognizes the obstacle", });
            builder.HasData(new Project() { Id = 6, CreateDate = DateTime.Now, Date = new DateTime(2020, 6, 1), Title = "Piezoelectric Energy Harvesters", Description = "Simulated and analyzed energy harvesting of piezoelectric sensor using MATLAB Simulink", });
            builder.HasData(new Project() { Id = 5, CreateDate = DateTime.Now, Date = new DateTime(2020, 6, 1), Title = "Designing a Portable Arm Injection System", Description = "Simulated desired design using MATLAB Simulink, researched bio-mechatronic market extensively, designed a system using Solidworks", });
            builder.HasData(new Project() { Id = 4, CreateDate = DateTime.Now, Date = new DateTime(2019, 12, 30), Title = "Production Line Design with PLC", Description = "Designing a system containing, wiring and coding given as a class project using Siemens Simatic, BECKHOFF Twincat and PLC", });
            builder.HasData(new Project() { Id = 3, CreateDate = DateTime.Now, Date = new DateTime(2018, 12, 30), Title = "Implementing Bicycle in to Solidworks", Description = "Provided comprehensive 3D construction of a bicycle in Solidworks including dynamic parts", });
            builder.HasData(new Project() { Id = 2, CreateDate = DateTime.Now, Date = new DateTime(2016, 12, 30), Title = "Researching Evolutionary Roots of Consumption", Description = "Provided market analysis by conducting polls for several products By analyzing polls defined the relationship between consumption choice and Evolutionary Roots", });
            builder.HasData(new Project() { Id = 1, CreateDate = DateTime.Now, Date = new DateTime(2015, 12, 30), Title = "Civic Involvement Project", Description = "Voluntarily contributed to the social improvements of elementary school students in Istanbul", });

        }
    }
}
