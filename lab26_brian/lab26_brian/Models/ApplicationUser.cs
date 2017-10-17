using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace lab26_brian.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthday { get; set; }
        [DisplayName("Alternate Email - Avoid work/school/ISP provided emails")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address")]
        public string AlternateEmail { get; set; }
    }
}
