using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;

namespace MySite_MVC.Models.Components
{
    public class ProjectViewComponent : ViewComponent
    {
        private readonly IManager<Project> project;

        public ProjectViewComponent(IManager<Project> project)
        {
            this.project = project;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Bu bolum Daha sonra degistirilecek. Gelen Kullanicinin Role'une gore veriler cekilecek
            var projects = project.GetAll();
            return View(projects);
        }
    }
}