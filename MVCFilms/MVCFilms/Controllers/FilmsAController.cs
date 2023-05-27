using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCFilms.Data;
using MVCFilms.Models;

namespace MVCFilms.Controllers
{
    public class FilmsAController : Controller
    {
        private readonly MVCFilmsContext _context;

        public FilmsAController(MVCFilmsContext context)
        {
            _context = context;
        }

        // GET: FilmsA
        public async Task<IActionResult> Index()
        {
              return _context.Films != null ? 
                          View(await _context.Films.ToListAsync()) :
                          Problem("Entity set 'MVCFilmsContext.Films'  is null.");
        }

        // GET: FilmsA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var films = await _context.Films
                .FirstOrDefaultAsync(m => m.ID == id);
            if (films == null)
            {
                return NotFound();
            }

            return View(films);
        }

        // GET: FilmsA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FilmsA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,DataLancamento,Description,Gender,Price")] Films films)
        {
            if (ModelState.IsValid)
            {
                _context.Add(films);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(films);
        }

        // GET: FilmsA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var films = await _context.Films.FindAsync(id);
            if (films == null)
            {
                return NotFound();
            }
            return View(films);
        }

        // POST: FilmsA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,DataLancamento,Description,Gender,Price")] Films films)
        {
            if (id != films.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(films);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmsExists(films.ID))
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
            return View(films);
        }

        // GET: FilmsA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var films = await _context.Films
                .FirstOrDefaultAsync(m => m.ID == id);
            if (films == null)
            {
                return NotFound();
            }

            return View(films);
        }

        // POST: FilmsA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Films == null)
            {
                return Problem("Entity set 'MVCFilmsContext.Films'  is null.");
            }
            var films = await _context.Films.FindAsync(id);
            if (films != null)
            {
                _context.Films.Remove(films);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmsExists(int id)
        {
          return (_context.Films?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
