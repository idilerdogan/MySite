using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySite.Entities.Entities.Concrete;
using MySite.Entities.EntityConfig.Abstract;

namespace MySite.Entities.EntityConfig.Concrete
{


    public class RoleConfig : BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.RoleName).HasMaxLength(50);
            builder.HasIndex(p => p.RoleName).IsUnique();

            builder.HasData(new Role() { Id = 1, RoleName = "Admin", CreateDate = DateTime.Now });
            builder.HasData(new Role() { Id = 2, RoleName = "User", CreateDate = DateTime.Now });
        }
    }

}
