using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AuthrecationWebSite.Data
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [StringLength(3,ErrorMessage ="{0}最多{1}個字元")]
        [Display(Name ="國別碼")]
        public string CountryCode { get; set; }
    }
}
