using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Barcode_Taqeem.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the IdentityUser_Employee class
    public class IdentityUser_Employee : IdentityUser
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Work Email")]
        public string WorkEmail { get; set; }

    }
}
