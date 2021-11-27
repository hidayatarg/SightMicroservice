using Microsoft.AspNetCore.Identity;

namespace FreeCourse.IdentityServer.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Inherit properties from IdentityUser
        // Extra Fields

        public string City { get; set; }
    }
}
