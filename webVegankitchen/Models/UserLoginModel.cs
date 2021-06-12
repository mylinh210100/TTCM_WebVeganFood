using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webVegankitchen.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "You have to in put this field")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You have to in put this field")]
        public string Pass { get; set; }
    }
}