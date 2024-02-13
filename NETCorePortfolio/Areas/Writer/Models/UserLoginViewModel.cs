using System.ComponentModel.DataAnnotations;

namespace NETCorePortfolio.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz..")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi giriniz..")]
        public string Password { get; set; }


    }
}
