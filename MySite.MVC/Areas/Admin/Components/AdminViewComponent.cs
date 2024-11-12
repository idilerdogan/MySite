using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Areas.Admin.Components
{
    public class AdminViewComponent: ViewComponent
    {
        private readonly IManager<MainMenu> menuManager;

        public AdminViewComponent(IManager<MainMenu> menuManager)
        {
            this.menuManager = menuManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //bu bölüm daha sonra düzelticelecek
            var menues = menuManager.GetAll();
            return View(menues);
        }
    }
}
