using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class UserViewComponent : ViewComponent
    {
        private readonly IManager<User> user;

        public UserViewComponent(IManager<User> user)
        {
            this.user = user;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var users = user.GetAll();
            return View(users);
        }
    }
}