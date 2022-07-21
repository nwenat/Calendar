using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class Event
    {
        public int Id { get; set; }
        //[NotMapped]
        //public string EncryptedId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }
        [Required]
        public DateTime From { get; set; }
        [Required]
        public DateTime To { get; set; }
        [Required]
        public Priority? Priority { get; set; }
    }
}
