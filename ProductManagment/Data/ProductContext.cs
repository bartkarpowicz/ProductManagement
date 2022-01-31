using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagment.Models;

namespace ProductManagment.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
          : base(options)
        {
        }
        public DbSet<ProductManagment.Models.Product> Product { get; set; }
        public DbSet<ProductManagment.Models.Brand> Brand { get; set; }
        public DbSet<ProductManagment.Models.Section> Section { get; set; }
        public DbSet<ProductManagment.Models.Material> Material { get; set; }
        public DbSet<ProductManagment.Models.prodType> prodType { get; set; }
        

    }
}
