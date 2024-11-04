using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class AchievementViewComponent:ViewComponent
    {
        private readonly IManager<Achievement> achievement;

        public AchievementViewComponent(IManager<Achievement> achievement)
        {
            this.achievement = achievement;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var menuler = achievement.GetAll();
            return View(menuler);
        }
    }
}