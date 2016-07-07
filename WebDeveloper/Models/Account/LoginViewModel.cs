using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Models.Account
{
    public class LoginViewModel
    {
        [Display (Name = "User Name")]
        [Required (ErrorMessage = "This field is required")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]        
        [DataType(DataType.Password)]        
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]       
        public bool RememberMe { get; set; }
    }
}
