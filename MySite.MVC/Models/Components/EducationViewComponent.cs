using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class EducationViewComponent : ViewComponent
    {
        private readonly IManager<Education> education;

        public EducationViewComponent(IManager<Education> education)
        {
            this.education = education;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var educations = education.GetAll();
            return View(educations);
        }
    }
}