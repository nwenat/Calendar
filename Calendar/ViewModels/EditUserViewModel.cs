using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();
            Claims = new List<string>();
        }
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public List<string> Roles { get; set; }
        public List<string> Claims { get; set; }
    }
}
