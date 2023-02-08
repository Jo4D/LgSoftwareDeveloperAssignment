using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LgSoftwareDeveloperAssignment.PresentationLayer
{
    public class SignInModel
    {
        public string UserName { get; set; }
        [Required]
        [MaxLength(16), MinLength(8)]
        [Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}
