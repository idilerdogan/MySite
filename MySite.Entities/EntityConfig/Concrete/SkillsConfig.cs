using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class SkillsConfig : BaseConfig<Skill>
    {
        public override void Configure(EntityTypeBuilder<Skill> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.ComputerSkills).HasMaxLength(100);

            builder.HasData(new Skill() { Id = 1, CreateDate = DateTime.Now, ComputerSkills = "Microsoft Office Tools: Word, Excel, PowerPoint" });
            builder.HasData(new Skill() { Id = 2, CreateDate = DateTime.Now, ComputerSkills = "PLC" });
            builder.HasData(new Skill() { Id = 3, CreateDate = DateTime.Now, ComputerSkills = "Arduino" });
            builder.HasData(new Skill() { Id = 4, CreateDate = DateTime.Now, ComputerSkills = "MATLAB" });
            builder.HasData(new Skill() { Id = 5, CreateDate = DateTime.Now, ComputerSkills = "Solidworks" });
            builder.HasData(new Skill() { Id = 6, CreateDate = DateTime.Now, ComputerSkills = "COMSOL" });
            builder.HasData(new Skill() { Id = 7, CreateDate = DateTime.Now, ComputerSkills = "Xilinx" });
            builder.HasData(new Skill() { Id = 8, CreateDate = DateTime.Now, ComputerSkills = "Solidworks" });
            builder.HasData(new Skill() { Id = 9, CreateDate = DateTime.Now, ComputerSkills = "Microsoft Visual Studio, Microsoft Visual Codes, C#" });
            builder.HasData(new Skill() { Id = 10, CreateDate = DateTime.Now, ComputerSkills = "SQL, PostgreSQL, SQLite" });
            builder.HasData(new Skill() { Id = 11, CreateDate = DateTime.Now, ComputerSkills = "\r\nObject-Oriented Programming (OOP)" });
            builder.HasData(new Skill() { Id = 12, CreateDate = DateTime.Now, ComputerSkills = "\r\nEntity Framework (EF) Core" });
            builder.HasData(new Skill() { Id = 13, CreateDate = DateTime.Now, ComputerSkills = "\r\nHTML, CSS" });




        }
    }
}
