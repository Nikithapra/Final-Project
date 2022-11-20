using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectMVC.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    //[PersonalData]
    //public string Fname { get; set; }
    //[Column(TypeName = "nvarchar(100)")]

    //[PersonalData]
    //public string Lname { get; set; }


}
