using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;
using MySite_MVC.Areas.Admin.Models_VMs;
using MySite_MVC.Models.VMs;
using System.Security.Claims;

namespace MySite_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserController(IManager<User> userManager
                               , INotyfService notyfService
                               , IMapper mapper
                               , IManager<Role> roleManager
                               , IHostEnvironment hostEnvironment) : Controller
    {
        public IActionResult Index()
        {
            var users = userManager.GetAllInclude(null, p => p.Roles).ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult UserInsertAdmin()
        {
            UserInsertAdminVM userInsertVM = new UserInsertAdminVM();
            var Roles = roleManager.GetAll();
            foreach (var role in Roles)
            {
                CheckBoxVM checkBoxVM = new CheckBoxVM()
                {
                    Id = role.Id,
                    LabelName = role.RoleName,
                    IsChecked = false

                };
                userInsertVM.Roles.Add(checkBoxVM);
            }
            return View(userInsertVM);
        }
        [HttpPost]
        public async Task<IActionResult> UserInsert(UserInsertAdminVM insertVM)
        {

            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(insertVM);
            }

            #region Fotograf Kaydetme
            string uploads = "";
            string userImagePAth = "";
            if (insertVM.Picture != null
                && (insertVM.Picture.ContentType.Contains("image/jpeg") || insertVM.Picture.ContentType.Contains("image/png")))
            {
                //Dosya ismin alma 
                var fileName = Path.GetFileName(insertVM.Picture.FileName);
                //Dosya Extension bulma
                var extension = Path.GetExtension(fileName);
                //Birlestirme işlemi 
                var newFileName = string.Concat(Guid.NewGuid().ToString(), extension);
                userImagePAth = $@"/images/{newFileName}";
                uploads = Path.Combine(hostEnvironment.ContentRootPath, $@"wwwroot/images/{newFileName}");
                string filePath = Path.Combine(uploads, newFileName);
                using (var fileStream = new System.IO.FileStream(uploads, FileMode.Create))
                {
                    await fileStream.CopyToAsync(fileStream);
                }
            }
            #endregion
            // Burada insertvm User sinifina çevrilmesi lazim

            #region Amele Yontemi
            
            User myUser = new User();
            myUser.Name = insertVM.Name;
            myUser.SurName = insertVM.Surname;
            myUser.Email = insertVM.Email;
            myUser.Phone = insertVM.Phone;
            myUser.Achievements=insertVM.Achievement;
            myUser.Activities=insertVM.Activities;
            myUser.Education=insertVM.Education;
            myUser.Experiances=insertVM.Experience;
            myUser.Languages=insertVM.Language;
            myUser.Projects = insertVM.Project;
            myUser.Skills = insertVM.Skill;


            myUser.CreateDate = DateTime.Now;
            
            myUser.Password = insertVM.Password;

           // myUser.PhotoPath = userImagePAth;
            
            #endregion

            //var myUser = mapper.Map<User>(insertVM);
            try
            {
                userManager.Create(myUser);
                myUser.Roles = new List<Role>();

                #region Kullaniciya check edilen rollerin atanmasi
                foreach (var item in insertVM.Roles.Where(p => p.IsChecked == true).ToList())
                {
                    var role = roleManager.GetById(item.Id);
                    myUser.Roles.Add(role);
                }
                // user role db'den cekilir


                userManager.Update(myUser);
            }
            catch (SqlException sqlException)
            {

                notyfService.Error("Hata Olustu :" + sqlException.InnerException);
                return View(insertVM);
            }
            catch (Exception ex)
            {
                var message = ex.InnerException.Message.Split(".")[2];
                notyfService.Error("Hata Olustu :" + message);
                return View(insertVM);
            }

            #endregion
            notyfService.Success("Islem Basarili");



            // userManager.Create(insertVM);

            return RedirectToAction("Index", "User", new { Area = "Admin" });

        }

        public IActionResult GetUser()
        {
            var TcNo = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = userManager.GetAllInclude(p => p.Email == TcNo, p => p.Roles).FirstOrDefault();

            return View(user);
        }
        public IActionResult Insert()
        {
            
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        //public IActionResult Delete()
        //{
        //    User myUser = new User();
            
        //    myUser.
        //       // = userManager.Delete()
        //    return View(myUser);
        //}
    }
}