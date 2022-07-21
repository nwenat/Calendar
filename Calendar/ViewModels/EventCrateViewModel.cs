using Calendar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.ViewModels
{
    public class EventCrateViewModel
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        //[Required]
        //public string UName { get; set; }
        [Required]
        [Display(Name = "Data:")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "Wybierz priorytet:")]
        public Priority? Priority { get; set; }
        [Required]
        [Range(0, 24)]
        public int FromHour { get; set; }
        [Range(0, 24)]
        public int ToHour { get; set; }
        [Range(0, 60)]
        public int FromMinutes { get; set; }
        [Range(0, 60)]
        public int ToMinutes { get; set; }
    }
}
