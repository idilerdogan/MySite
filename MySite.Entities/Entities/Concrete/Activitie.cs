using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Activitie : BaseEntity
    {
        public DateOnly DateBegining { get; set; }
        public DateOnly DateEnding { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
