using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagment.Models
{
    public class Section
    {
        [Key]
        [Display(Name = "Identyfikator")]
        [MaxLength(1, ErrorMessage = "Max 1 chars")]
        public string Id { get; set; }

        [Display(Name = "Dział")]
        [MaxLength(50, ErrorMessage = "Max 50 chars")]
        public string Name { get; set; }
    }
}
