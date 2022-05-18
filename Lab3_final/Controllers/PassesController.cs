using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab3_final.Data;
using Lab3_final.Models;

namespace Lab3_final.Controllers
{
    public class PassesController : Controller
    {
        private readonly Lab3_finalContext _context;

        public PassesController(Lab3_finalContext context)
        {
            _context = context;
        }

        // GET: Passes
        public async Task<IActionResult> Index()
        {
              return _context.Pass != null ? 
                          View(await _context.Pass.ToListAsync()) :
                          Problem("Entity set 'Lab3_finalContext.Pass'  is null.");
        }

        // GET: Passes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pass == null)
            {
                return NotFound();
            }

            var pass = await _context.Pass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pass == null)
            {
                return NotFound();
            }

            return View(pass);
        }

        // GET: Passes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Passes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Pass pass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pass);
        }

        // GET: Passes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pass == null)
            {
                return NotFound();
            }

            var pass = await _context.Pass.FindAsync(id);
            if (pass == null)
            {
                return NotFound();
            }
            return View(pass);
        }

        // POST: Passes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Pass pass)
        {
            if (id != pass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassExists(pass.Id))
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
            return View(pass);
        }

        // GET: Passes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pass == null)
            {
                return NotFound();
            }

            var pass = await _context.Pass
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pass == null)
            {
                return NotFound();
            }

            return View(pass);
        }

        // POST: Passes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pass == null)
            {
                return Problem("Entity set 'Lab3_finalContext.Pass'  is null.");
            }
            var pass = await _context.Pass.FindAsync(id);
            if (pass != null)
            {
                _context.Pass.Remove(pass);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassExists(int id)
        {
          return (_context.Pass?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
