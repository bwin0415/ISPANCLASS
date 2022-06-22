using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Customers2019.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email不可以空白")]
        [EmailAddress(ErrorMessage = "Email格式錯誤")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Name不可以空白")]
        public string Name { get; set; }
    }
}
