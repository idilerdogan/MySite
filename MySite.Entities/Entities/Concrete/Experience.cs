using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Experience : BaseEntity
    {
        public string ExPlace { get; set; }
        public string ExTitle { get; set; }
        public DateOnly ExBeginning { get; set; }
        public DateOnly ExEnding { get; set; }
        public string ExDescription { get; set; }

    }
}
