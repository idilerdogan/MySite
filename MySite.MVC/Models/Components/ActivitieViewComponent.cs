using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class ActivitieViewComponent : ViewComponent
    {
        private readonly IManager<Activitie> activitie;

        public ActivitieViewComponent(IManager<Activitie> activitie)
        {
            this.activitie = activitie;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var activities = activitie.GetAll();
            return View(activities);
        }
    }
}