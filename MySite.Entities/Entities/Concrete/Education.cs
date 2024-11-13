using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Education : BaseEntity
    {
        public string ScName { get; set; }
        public DateTime ScBeginning { get; set; }
        public DateTime ScEndning { get; set; }
        public string? Description { get; set; }
        public string Degree { get; set; }
    }
}
