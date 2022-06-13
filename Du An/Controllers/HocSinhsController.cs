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
    public class HocSinhsController : Controller
    {
        private readonly ELearningContext _context;

        public HocSinhsController(ELearningContext context)
        {
            _context = context;
        }

        // GET: HocSinhs
        public async Task<IActionResult> Index()
        {
            var eLearningContext = _context.HocSinhs.Include(h => h.IdnienKhoaNavigation).Include(h => h.MaLopNavigation).Include(h => h.MaMhNavigation);
            return View(await eLearningContext.ToListAsync());
        }

        // GET: HocSinhs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HocSinhs == null)
            {
                return NotFound();
            }

            var hocSinh = await _context.HocSinhs
                .Include(h => h.IdnienKhoaNavigation)
                .Include(h => h.MaLopNavigation)
                .Include(h => h.MaMhNavigation)
                .FirstOrDefaultAsync(m => m.MaHs == id);
            if (hocSinh == null)
            {
                return NotFound();
            }

            return View(hocSinh);
        }

        // GET: HocSinhs/Create
        public IActionResult Create()
        {
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa");
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop");
            ViewData["MaMh"] = new SelectList(_context.Monhocs, "MaMh", "MaMh");
            return View();
        }

        // POST: HocSinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHs,TenHs,GioiTinh,NgaySinh,Gvcn,IdnienKhoa,MaLop,MaMh")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hocSinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa", hocSinh.IdnienKhoa);
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop", hocSinh.MaLop);
            ViewData["MaMh"] = new SelectList(_context.Monhocs, "MaMh", "MaMh", hocSinh.MaMh);
            return View(hocSinh);
        }

        // GET: HocSinhs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.HocSinhs == null)
            {
                return NotFound();
            }

            var hocSinh = await _context.HocSinhs.FindAsync(id);
            if (hocSinh == null)
            {
                return NotFound();
            }
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa", hocSinh.IdnienKhoa);
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop", hocSinh.MaLop);
            ViewData["MaMh"] = new SelectList(_context.Monhocs, "MaMh", "MaMh", hocSinh.MaMh);
            return View(hocSinh);
        }

        // POST: HocSinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHs,TenHs,GioiTinh,NgaySinh,Gvcn,IdnienKhoa,MaLop,MaMh")] HocSinh hocSinh)
        {
            if (id != hocSinh.MaHs)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hocSinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocSinhExists(hocSinh.MaHs))
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
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa", hocSinh.IdnienKhoa);
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop", hocSinh.MaLop);
            ViewData["MaMh"] = new SelectList(_context.Monhocs, "MaMh", "MaMh", hocSinh.MaMh);
            return View(hocSinh);
        }

        // GET: HocSinhs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.HocSinhs == null)
            {
                return NotFound();
            }

            var hocSinh = await _context.HocSinhs
                .Include(h => h.IdnienKhoaNavigation)
                .Include(h => h.MaLopNavigation)
                .Include(h => h.MaMhNavigation)
                .FirstOrDefaultAsync(m => m.MaHs == id);
            if (hocSinh == null)
            {
                return NotFound();
            }

            return View(hocSinh);
        }

        // POST: HocSinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.HocSinhs == null)
            {
                return Problem("Entity set 'ELearningContext.HocSinhs'  is null.");
            }
            var hocSinh = await _context.HocSinhs.FindAsync(id);
            if (hocSinh != null)
            {
                _context.HocSinhs.Remove(hocSinh);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HocSinhExists(string id)
        {
          return (_context.HocSinhs?.Any(e => e.MaHs == id)).GetValueOrDefault();
        }
    }
}
