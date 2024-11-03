using System.ComponentModel.DataAnnotations;

namespace MySite_MVC.Models.VMs
{
    public class LoginVM
    {

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Kullanıcı Adı girilmek zorundadir")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre  girilmesi zorunludur")]
        public string Password { get; set; }

        public bool RememberMe { get; set; } = false;
    }
}