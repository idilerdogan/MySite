using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{
    public class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.SurName).HasMaxLength(50);
            builder.Property(p => p.Phone).HasMaxLength(19);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(200);

            builder.Property(p => p.Password).HasMaxLength(500);
            builder.Property(p => p.UserName).HasMaxLength(500);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.UserName).IsUnique();

            builder.HasData((new User() { Id = 1, CreateDate = DateTime.Now, Name = "İdil", SurName = "Erdoğan", Password = "qwe", UserName = "idilerdogan", Email="idilerdogan@sabanciuniv.edu", Phone="+90 539 371 69 85", }));
        }
    }
}
