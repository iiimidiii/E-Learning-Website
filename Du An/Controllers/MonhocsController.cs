using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Du_An.Models;

namespace Du_An.Controllers
{
    public class MonhocsController : Controller
    {
        private readonly ELearningContext _context;

        public MonhocsController(ELearningContext context)
        {
            _context = context;
        }

        // GET: Monhocs
        public async Task<IActionResult> Index()
        {
              return _context.Monhocs != null ? 
                          View(await _context.Monhocs.ToListAsync()) :
                          Problem("Entity set 'ELearningContext.Monhocs'  is null.");
        }

        // GET: Monhocs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Monhocs == null)
            {
                return NotFound();
            }

            var monhoc = await _context.Monhocs
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (monhoc == null)
            {
                return NotFound();
            }

            return View(monhoc);
        }

        // GET: Monhocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monhocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMh,TenMh")] Monhoc monhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monhoc);
        }

        // GET: Monhocs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Monhocs == null)
            {
                return NotFound();
            }

            var monhoc = await _context.Monhocs.FindAsync(id);
            if (monhoc == null)
            {
                return NotFound();
            }
            return View(monhoc);
        }

        // POST: Monhocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaMh,TenMh")] Monhoc monhoc)
        {
            if (id != monhoc.MaMh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monhoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonhocExists(monhoc.MaMh))
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
            return View(monhoc);
        }

        // GET: Monhocs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Monhocs == null)
            {
                return NotFound();
            }

            var monhoc = await _context.Monhocs
                .FirstOrDefaultAsync(m => m.MaMh == id);
            if (monhoc == null)
            {
                return NotFound();
            }

            return View(monhoc);
        }

        // POST: Monhocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Monhocs == null)
            {
                return Problem("Entity set 'ELearningContext.Monhocs'  is null.");
            }
            var monhoc = await _context.Monhocs.FindAsync(id);
            if (monhoc != null)
            {
                _context.Monhocs.Remove(monhoc);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonhocExists(string id)
        {
          return (_context.Monhocs?.Any(e => e.MaMh == id)).GetValueOrDefault();
        }
    }
}
