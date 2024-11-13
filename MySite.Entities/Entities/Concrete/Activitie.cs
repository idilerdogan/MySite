using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Activitie : BaseEntity
    {
        public DateTime DateBegining { get; set; }
        public DateTime DateEnding { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
