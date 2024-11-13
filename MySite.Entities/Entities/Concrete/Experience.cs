using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class Experience : BaseEntity
    {
        public string ExPlace { get; set; }
        public string ExTitle { get; set; }
        public DateTime ExBeginning { get; set; }
        public DateTime ExEnding { get; set; }
        public string ExDescription { get; set; }

    }
}
