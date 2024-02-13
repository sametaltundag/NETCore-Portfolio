using System.ComponentModel.DataAnnotations;

namespace NETCorePortfolio.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı girin!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı girin!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi girin!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Image Url girin!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi onaylayın girin!")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen epostasınız girin!")]
        public string Email { get; set; }
    }
}
