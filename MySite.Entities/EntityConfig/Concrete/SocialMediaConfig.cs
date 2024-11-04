using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class SocialMediaConfig : BaseConfig<SocialMedia>
    {
        public override void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);

            builder.HasData(new SocialMedia() { Id = 1, CreateDate = DateTime.Now, Name = "LinkedIn", Medialink = "\r\nhttps://www.linkedin.com/in/idil-erdoğan-725458159/" });


        }
    }
}
