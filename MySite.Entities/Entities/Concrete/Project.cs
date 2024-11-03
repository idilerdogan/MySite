using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Project : BaseEntity
    {
        public DateOnly Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
