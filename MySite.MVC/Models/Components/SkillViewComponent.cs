using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class SkillViewComponent : ViewComponent
    {
        private readonly IManager<Skill> skill;

        public SkillViewComponent(IManager<Skill> skill)
        {
            this.skill = skill;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var skills = skill.GetAll();
            return View(skills);
        }
    }
}