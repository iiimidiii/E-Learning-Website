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
    public class GiaoViensController : Controller
    {
        private readonly ELearningContext _context;

        public GiaoViensController(ELearningContext context)
        {
            _context = context;
        }

        // GET: GiaoViens
        public async Task<IActionResult> Index()
        {
            var eLearningContext = _context.GiaoViens.Include(g => g.IdnienKhoaNavigation).Include(g => g.IdvaiTroNavigation).Include(g => g.MaLopNavigation).Include(g => g.MaQuyenHanNavigation);
            return View(await eLearningContext.ToListAsync());
        }

        // GET: GiaoViens/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GiaoViens == null)
            {
                return NotFound();
            }

            var giaoVien = await _context.GiaoViens
                .Include(g => g.IdnienKhoaNavigation)
                .Include(g => g.IdvaiTroNavigation)
                .Include(g => g.MaLopNavigation)
                .Include(g => g.MaQuyenHanNavigation)
                .FirstOrDefaultAsync(m => m.MaGv == id);
            if (giaoVien == null)
            {
                return NotFound();
            }

            return View(giaoVien);
        }

        // GET: GiaoViens/Create
        public IActionResult Create()
        {
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa");
            ViewData["IdvaiTro"] = new SelectList(_context.VaiTroGiaoViens, "IdvaiTro", "IdvaiTro");
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop");
            ViewData["MaQuyenHan"] = new SelectList(_context.QuyenHans, "MaQuyenHan", "MaQuyenHan");
            return View();
        }

        // POST: GiaoViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaGv,TenGv,GioiTinh,NgaySinh,IdvaiTro,MaMh,IdnienKhoa,MaQuyenHan,MaLop")] GiaoVien giaoVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(giaoVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa", giaoVien.IdnienKhoa);
            ViewData["IdvaiTro"] = new SelectList(_context.VaiTroGiaoViens, "IdvaiTro", "IdvaiTro", giaoVien.IdvaiTro);
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop", giaoVien.MaLop);
            ViewData["MaQuyenHan"] = new SelectList(_context.QuyenHans, "MaQuyenHan", "MaQuyenHan", giaoVien.MaQuyenHan);
            return View(giaoVien);
        }

        // GET: GiaoViens/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GiaoViens == null)
            {
                return NotFound();
            }

            var giaoVien = await _context.GiaoViens.FindAsync(id);
            if (giaoVien == null)
            {
                return NotFound();
            }
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa", giaoVien.IdnienKhoa);
            ViewData["IdvaiTro"] = new SelectList(_context.VaiTroGiaoViens, "IdvaiTro", "IdvaiTro", giaoVien.IdvaiTro);
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop", giaoVien.MaLop);
            ViewData["MaQuyenHan"] = new SelectList(_context.QuyenHans, "MaQuyenHan", "MaQuyenHan", giaoVien.MaQuyenHan);
            return View(giaoVien);
        }

        // POST: GiaoViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaGv,TenGv,GioiTinh,NgaySinh,IdvaiTro,MaMh,IdnienKhoa,MaQuyenHan,MaLop")] GiaoVien giaoVien)
        {
            if (id != giaoVien.MaGv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(giaoVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiaoVienExists(giaoVien.MaGv))
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
            ViewData["IdnienKhoa"] = new SelectList(_context.NienKhoas, "IdnienKhoa", "IdnienKhoa", giaoVien.IdnienKhoa);
            ViewData["IdvaiTro"] = new SelectList(_context.VaiTroGiaoViens, "IdvaiTro", "IdvaiTro", giaoVien.IdvaiTro);
            ViewData["MaLop"] = new SelectList(_context.Lops, "MaLop", "MaLop", giaoVien.MaLop);
            ViewData["MaQuyenHan"] = new SelectList(_context.QuyenHans, "MaQuyenHan", "MaQuyenHan", giaoVien.MaQuyenHan);
            return View(giaoVien);
        }

        // GET: GiaoViens/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GiaoViens == null)
            {
                return NotFound();
            }

            var giaoVien = await _context.GiaoViens
                .Include(g => g.IdnienKhoaNavigation)
                .Include(g => g.IdvaiTroNavigation)
                .Include(g => g.MaLopNavigation)
                .Include(g => g.MaQuyenHanNavigation)
                .FirstOrDefaultAsync(m => m.MaGv == id);
            if (giaoVien == null)
            {
                return NotFound();
            }

            return View(giaoVien);
        }

        // POST: GiaoViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GiaoViens == null)
            {
                return Problem("Entity set 'ELearningContext.GiaoViens'  is null.");
            }
            var giaoVien = await _context.GiaoViens.FindAsync(id);
            if (giaoVien != null)
            {
                _context.GiaoViens.Remove(giaoVien);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiaoVienExists(string id)
        {
          return (_context.GiaoViens?.Any(e => e.MaGv == id)).GetValueOrDefault();
        }
    }
}
