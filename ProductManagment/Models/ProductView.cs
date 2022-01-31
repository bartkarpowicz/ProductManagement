using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagment.Models
{
    public class ProductView
    {
        [Key]
        public int Id { get; set; }
        public Product productVm { get; set; }
        public Brand brandVm { get; set; }
        public Section sectionVm { get; set; }
        public Material materialVm { get; set; }
        public prodType prodTypeVm { get; set; }

    }
}
