using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace LgSoftwareDeveloperAssignment.PresentationLayer
{
    public class UserCreateModel
    {
        [MaxLength(50), MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(50), MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(50), MinLength(4)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(50), MinLength(4)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [MaxLength(50), MinLength(4)]
        [Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password"), DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [DefaultValue("Admin")]
        public string Role { set; get; }
    }
}
