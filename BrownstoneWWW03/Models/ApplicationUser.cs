using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BrownstoneWWW03.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(80)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(80)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        public int? ApplicationOrganizationID { get; set; }

        public ApplicationOrganization ApplicationOrganization { get; set; }

    }
}
