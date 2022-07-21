using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class EventEditViewModel : EventCrateViewModel
    {
        [Required]
        public int Id { get; set; }
    }
}
