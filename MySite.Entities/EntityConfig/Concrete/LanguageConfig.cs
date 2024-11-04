using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class LanguageConfig : BaseConfig<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Languages).HasMaxLength(50);

            builder.HasData(new Language() { Id = 1, CreateDate = DateTime.Now, Languages = "Turkish Mother Language" });
            builder.HasData(new Language() { Id = 2, CreateDate = DateTime.Now, Languages = "English Upper Intermediate" });
            builder.HasData(new Language() { Id = 3, CreateDate = DateTime.Now, Languages = "Germany Elemantary" });


        }
    }
}
