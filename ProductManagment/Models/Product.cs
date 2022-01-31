using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagment.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podac nazwę produktu")]
        [Display(Name = "Nazwa produktu")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]

        public string Name { get; set; }

        [Display(Name = "Marka produktu")]
        [Required]
        [MaxLength(5, ErrorMessage = "Max 5 char")]

        public string Brand { get; set; }

        [Display(Name = "Cena produktu")]
        [Required]


        public int ProductPrice { get; set; }

        [Display(Name = "Dział")]
        [Required]
        [MaxLength(1, ErrorMessage = "Max 1 char")]

        public string Section { get; set; }

        [Display(Name = "Materiał")]
        [Required]
        [MaxLength(5, ErrorMessage = "Max 5 char")]

        public string Material { get; set; }

        [Display(Name = "Typ")]
        [Required]
        [MaxLength(5, ErrorMessage = "Max 5 char")]

        public string Type { get; set; }
    }
}
