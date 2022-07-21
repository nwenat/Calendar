using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Nazwa jest wymagana!")]
        [Display(Name = "Nazwa")]
        [Remote(action: "IsNameInUse", controller:"Account")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane!")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Podane hasła są różne!")]
        public string ConfirmPassword { get; set; }
    }
}
