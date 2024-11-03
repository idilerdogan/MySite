using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IManager<MainMenu> menuManager;

        public MenuViewComponent(IManager<MainMenu> menuManager)
        {
            this.menuManager = menuManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var menuler = menuManager.GetAll();
            return View(menuler);
        }
    }
}