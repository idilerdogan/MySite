using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class SocialMedia : BaseEntity
    {
        public string Name { get; set; }
        public string Medialink { get; set; }
        public string Icon { get; set; }
    }
}
