using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class SocialMediaViewComponent : ViewComponent
    {
        private readonly IManager<SocialMedia> socialMedia;

        public SocialMediaViewComponent(IManager<SocialMedia> socialMedia)
        {
            this.socialMedia = socialMedia;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var socialMedias = socialMedia.GetAll();
            return View(socialMedias);
        }
    }
}