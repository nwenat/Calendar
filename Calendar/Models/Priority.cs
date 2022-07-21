using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public enum Priority
    {
        [Display(Name = "Wysoki")]
        HIGH,
        [Display(Name = "Średni")]
        MEDIUM,
        [Display(Name = "Niski")]
        LOW
    }
}
