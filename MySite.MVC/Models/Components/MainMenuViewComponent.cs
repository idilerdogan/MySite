using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class MainMenuViewComponent : ViewComponent
    {
        private readonly IManager<MainMenu> menuManager;

        public MainMenuViewComponent(IManager<MainMenu> menuManager)
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