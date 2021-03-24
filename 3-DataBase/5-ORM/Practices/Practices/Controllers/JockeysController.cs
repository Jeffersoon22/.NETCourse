using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practices.Models;

namespace Practices.Controllers
{
    public class JockeysController : Controller
    {
        private readonly HorsesInRacesContext _context;

        public JockeysController(HorsesInRacesContext context)
        {
            _context = context;
        }

        // GET: Jockeys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jockeys.ToListAsync());
        }

        // GET: Jockeys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jockeys = await _context.Jockeys
                .FirstOrDefaultAsync(m => m.JockeyId == id);
            if (jockeys == null)
            {
                return NotFound();
            }

            return View(jockeys);
        }

        // GET: Jockeys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jockeys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JockeyId,Name,Address,Age,Rating")] Jockeys jockeys)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jockeys);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jockeys);
        }

        // GET: Jockeys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jockeys = await _context.Jockeys.FindAsync(id);
            if (jockeys == null)
            {
                return NotFound();
            }
            return View(jockeys);
        }

        // POST: Jockeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JockeyId,Name,Address,Age,Rating")] Jockeys jockeys)
        {
            if (id != jockeys.JockeyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jockeys);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JockeysExists(jockeys.JockeyId))
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
            return View(jockeys);
        }

        // GET: Jockeys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jockeys = await _context.Jockeys
                .FirstOrDefaultAsync(m => m.JockeyId == id);
            if (jockeys == null)
            {
                return NotFound();
            }

            return View(jockeys);
        }

        // POST: Jockeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jockeys = await _context.Jockeys.FindAsync(id);
            _context.Jockeys.Remove(jockeys);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JockeysExists(int id)
        {
            return _context.Jockeys.Any(e => e.JockeyId == id);
        }
    }
}
