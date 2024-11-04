using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly IManager<Experience> experiance;

        public ExperienceViewComponent(IManager<Experience> experiance)
        {
            this.experiance = experiance;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var experiances = experiance.GetAll();
            return View(experiances);
        }
    }
}