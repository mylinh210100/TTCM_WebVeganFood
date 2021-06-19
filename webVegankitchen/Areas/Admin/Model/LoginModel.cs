using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webVegankitchen.Areas.Admin.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "You must input this field")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You must input this field")]
        public string PassWord { get; set; }

        public bool RememberMe { get; set; }

    }
}