using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Achievement : BaseEntity
    {
        public DateTime AcDate { get; set; }
        public string Description { get; set; }
    }
}
