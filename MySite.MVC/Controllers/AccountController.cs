using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySite.BL.Abstract;
using MySite.Entities.Entities.Concrete;
using MySite_MVC.Models.VMs;

namespace MySite.MVC.Controllers
{
    [Authorize]
    public class AccountController(IManager<Role> roleManager
                                   , IManager<User> userManager
                                   , INotyfService notyfService
                                    , IMapper mapper) : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Users()
        {
            var users = userManager.GetAllInclude(null, p => p.Roles).ToList();
            return View(users);
        }
        [HttpGet]
        [AllowAnonymous] // Burasi Herkese açik hale gelir
        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }
        [HttpPost]
        [AllowAnonymous]
        //public IActionResult Login(string email,string password,bool rememberme)
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var user = userManager.GetAllInclude(p => p.UserName == loginVM.UserName && p.Password == loginVM.Password
            , p => p.Roles).FirstOrDefault();
            if (user == null)
            {
                notyfService.Error("Email yada Password hatalı");
                return View(loginVM);
            }

            // Cookie uzerinde tutulacak bilgileri tanimliyoruz. Yani Kimlik karti uzerindeki bilgiler gibi dusunebilirsiniz.
            string roles = "";
            foreach (var item in user.Roles)
            {
                roles += item.RoleName + " ";
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, loginVM.UserName),
                new Claim(ClaimTypes.Name,user.Name + " " + user.Name),
                new Claim(ClaimTypes.MobilePhone,user.Phone),
                new Claim(ClaimTypes.Email,user.Email + " " + user.Email),
                new Claim(ClaimTypes.Role,roles),
                //new Claim(ClaimTypes.UserData,user.PhotoPath)

            };
            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperty = new AuthenticationProperties()
            {
                IsPersistent = loginVM.RememberMe
            };
            var userClaimPrinciple = new ClaimsPrincipal(claimIdentity);


            //var signIn = HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity),
            //    _userService.AuthenticationOptions(model.RememberMe));

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                userClaimPrinciple, authenticationProperty);

            if (roles.Contains("Admin"))
            {
                return RedirectToAction("Index", "Home", new { Area = "Admin" });
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }



        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult UserInsert()
        {

            UserInsertVM userInsertVM = new UserInsertVM();
            return View(userInsertVM);
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult UserInsert(UserInsertVM insertVM)
        {

            if (!ModelState.IsValid)
            {

                notyfService.Error("Düzeltilmesi gereken yerler var");
                return View(insertVM);
            }
            // Burada insertvm MyUser sinifina çevrilmesi lazim

            #region Amele Yontemi

            //MyUser myUser = new MyUser();
            //myUser.Cinsiyet=insertVM.Cinsiyet;
            //myUser.Ad=insertVM.Ad;
            //myUser.Soyad=insertVM.Soyad;
            //myUser.Email=insertVM.Email;
            //myUser.TcNo=insertVM.TcNo;
            //myUser.Gsm=insertVM.Gsm;
            //myUser.CreateDate=DateTime.Now;
            //myUser.Password=insertVM.Password;
            #endregion

            var myUser = mapper.Map<User>(insertVM);
            userManager.Create(myUser);

            #region Kullaniciya Default olarak user rolü eklenir
            var role = roleManager.Get(p => p.RoleName == "user"); // user role db'den cekilir
            myUser.Roles = new List<Role>();
            myUser.Roles.Add(role);
            userManager.Update(myUser);
            #endregion
            notyfService.Success("Islem Basarili");



            // userManager.Create(insertVM);

            return RedirectToAction("Index", "Account", new { Area = "Admin" });

        }
    }
}