using Microsoft.AspNetCore.Mvc;
using ProductManagment.Data;
using ProductManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagment.Controllers
{
    public class ProductViewsController : Controller
    {
            private readonly ProductContext _context;

            public ProductViewsController(ProductContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                //HasNoKey();

                var alist = from p in _context.Product
                            join b in _context.Brand on p.Brand equals b.Id
                            join s in _context.Section on p.Section equals s.Id
                            join m in _context.Material on p.Material equals m.Id
                            join t in _context.prodType on p.Type equals t.Id

                            //where s.G_ID == 1
                            select new ProductView
                            {
                                productVm = p,
                                brandVm = b,
                                sectionVm = s,
                                materialVm = m,
                                prodTypeVm = t

                            };

                return View(alist.ToList());
                return View();
            }

            // GET: Students/Details/5
            public IActionResult Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

            var alist = from p in _context.Product
                        join b in _context.Brand on p.Brand equals b.Id
                        join s in _context.Section on p.Section equals s.Id
                        join m in _context.Material on p.Material equals m.Id
                        join t in _context.prodType on p.Type equals t.Id
                        where p.Id == id

                        //where s.G_ID == 1
                        select new ProductView
                        {
                            productVm = p,
                            brandVm = b,
                            sectionVm = s,
                            materialVm = m,
                            prodTypeVm = t

                        };

            return View(alist.FirstOrDefault());
        }
    }
}
