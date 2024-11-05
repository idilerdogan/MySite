using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MySite_MVC.Models;

namespace MySite_MVC.Controllers
{


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string page)
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public IActionResult About()
        //{
        //    return View();
        //}
        //public IActionResult Activitie()
        //{
        //    return View();
        //}
        //public IActionResult Achievement()
        //{
        //    return View();
        //}
        //public IActionResult Education()
        //{
        //    return View();
        //}
        //public IActionResult Experience()
        //{
        //    return View();
        //}
        //public IActionResult Language()
        //{
        //    return View();
        //}
        //public IActionResult Project()
        //{
        //    return View();
        //}
        //public IActionResult Skill()
        //{
        //    return View();
        //}


    }
}