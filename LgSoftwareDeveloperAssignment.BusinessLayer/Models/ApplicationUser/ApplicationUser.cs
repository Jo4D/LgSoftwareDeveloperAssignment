using Microsoft.AspNetCore.Identity;
namespace LgSoftwareDeveloperAssignment.BusinessLayer
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
