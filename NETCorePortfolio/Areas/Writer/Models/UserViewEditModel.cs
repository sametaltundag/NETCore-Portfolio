using Microsoft.AspNetCore.Http;

namespace NETCorePortfolio.Areas.Writer.Models
{
    public class UserViewEditModel
    {
        public string Name { get; set; }
        public string SUrname { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PictureUrl { get; set; }
        public IFormFile Picture { get; set; }
    }
}
