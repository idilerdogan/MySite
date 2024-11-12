using Microsoft.AspNetCore.Mvc;
using MySite_MVC.Models.VMs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MySite_MVC.Areas.Admin.Models_VMs
{
    public class UserInsertAdminVM : Controller
    {
        [Required(ErrorMessage = "Ad Alanı Zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalıdır")]
        [MaxLength(15, ErrorMessage = "En fazla 15 karakter olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalıdır")]
        [MaxLength(15, ErrorMessage = "En fazla 15 karakter olmalıdır")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email Alanı Zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "GSM Alanı Zorunludur")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }


        [Required(ErrorMessage = "Password Alanı Zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalıdır")]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter olmalıdır")]
        [DataType(DataType.Password)]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Alanı Zorunludur")]
        [MinLength(2, ErrorMessage = "En az 2 karakter olmalıdır")]
        [MaxLength(100, ErrorMessage = "En fazla 100 karakter olmalıdır")]
        [DataType(DataType.Password)]
        [DisplayName("Şifre tekrar")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Rol Alanı Zorunludur")]
        public List<CheckBoxVM> Roles { get; set; } = new List<CheckBoxVM>();

        //    [MaxLength(50, ErrorMessage ="Dosya büyüklüğü en fazla 50 Mb olmalıdır")]
        public IFormFile Picture { get; set; }



        public static implicit operator UserInsertAdminVM(UserInsertVM vm)
        {
            throw new NotImplementedException();
        }
    }
}