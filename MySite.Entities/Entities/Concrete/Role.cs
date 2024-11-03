using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public List<User> Users { get; set; }
    }
}
