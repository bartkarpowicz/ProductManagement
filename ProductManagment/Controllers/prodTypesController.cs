using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductManagment.Data;
using ProductManagment.Models;

namespace ProductManagment.Controllers
{
    public class prodTypesController : Controller
    {
        private readonly ProductContext _context;

        public prodTypesController(ProductContext context)
        {
            _context = context;
        }

        // GET: prodTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.prodType.ToListAsync());
        }

        // GET: prodTypes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodType = await _context.prodType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prodType == null)
            {
                return NotFound();
            }

            return View(prodType);
        }

        // GET: prodTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: prodTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] prodType prodType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prodType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prodType);
        }

        // GET: prodTypes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodType = await _context.prodType.FindAsync(id);
            if (prodType == null)
            {
                return NotFound();
            }
            return View(prodType);
        }

        // POST: prodTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name")] prodType prodType)
        {
            if (id != prodType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prodType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!prodTypeExists(prodType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(prodType);
        }

        // GET: prodTypes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prodType = await _context.prodType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prodType == null)
            {
                return NotFound();
            }

            return View(prodType);
        }

        // POST: prodTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var prodType = await _context.prodType.FindAsync(id);
            _context.prodType.Remove(prodType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool prodTypeExists(string id)
        {
            return _context.prodType.Any(e => e.Id == id);
        }
    }
}
