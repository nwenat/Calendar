using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class EditGroupViewModel
    {
        public EditGroupViewModel()
        {
            Users = new List<string>();
        }
        [Required]
        public string Id { get; set; }
        [Required]
        public string UN { get; set; }
        [Required]
        [Display(Name = "Nazwa grupy")]
        public string GroupName { get; set; }
        public List<string> Users { get; set; }
    }
}
