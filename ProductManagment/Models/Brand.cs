using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagment.Models
{
    public class Brand
    {
        [Key]
        [Display(Name = "Identyfikator")]
        [MaxLength(5, ErrorMessage = "Max 5 chars")]
        public string Id { get; set; }

        [Display(Name = "Nazwa")]
        [MaxLength(50, ErrorMessage = "Max 50 chars")]
        public string Name { get; set; }
    }
}
