using MySite.Entities.Entities.Abstract;

namespace MySite.Entities.Entities.Concrete
{
    public class MainMenu : BaseEntity
    {
        public string MenuName { get; set; }
        public string? ActionName { get; set; }
        public string? ControllerName { get; set; }
        public string? AreaName { get; set; }
        public string? ClassName { get; set; }
        public string? CssName { get; set; }
        public string? IconName { get; set; }

        public int? OrderNo { get; set; }
        public int? ParentMenuId { get; set; }
        public MainMenu? ParentMenu { get; set; }
        public int? RoleId { get; set; }
        public Role? Roles { get; set; }
    }
}
