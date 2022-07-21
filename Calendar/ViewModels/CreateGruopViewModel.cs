using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class CreateGruopViewModel
    {
        [Required]
        [Display(Name = "Nazwa nowej grupy")]
        public string GroupName { get; set; }

        [Required]
        public string userName { get; set; }
    }
}
