using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class LanguageViewComponent : ViewComponent
    {
        private readonly IManager<Language> language;

        public LanguageViewComponent(IManager<Language> language)
        {
            this.language = language;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var languages = language.GetAll();
            return View(languages);
        }
    }
}