using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class LoginViewModel
    {
        [Display(Name = "User")]
        [Required(ErrorMessage = "{0} required!")]
        public string User { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="{0} required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="Remind Me")]
        public bool RemindMe { get; set; }
    }
}