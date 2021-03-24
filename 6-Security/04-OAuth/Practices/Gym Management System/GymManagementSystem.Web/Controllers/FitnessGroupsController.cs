using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymManagementSystem.DAL;
using GymManagementSystem.DAL.Models;

namespace GymManagementSystem.Web.Controllers
{
    public class FitnessGroupsController : Controller
    {
        private readonly GymDbContext _context;

        public FitnessGroupsController(GymDbContext context)
        {
            _context = context;
        }

        // GET: FitnessGroups
        public async Task<IActionResult> Index()
        {
            return View(await _context.FitnessGroups.ToListAsync());
        }

        // GET: FitnessGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessGroup = await _context.FitnessGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fitnessGroup == null)
            {
                return NotFound();
            }

            return View(fitnessGroup);
        }

        // GET: FitnessGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FitnessGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StartTime,EndTime")] FitnessGroup fitnessGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fitnessGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fitnessGroup);
        }

        // GET: FitnessGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessGroup = await _context.FitnessGroups.FindAsync(id);
            if (fitnessGroup == null)
            {
                return NotFound();
            }
            return View(fitnessGroup);
        }

        // POST: FitnessGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StartTime,EndTime")] FitnessGroup fitnessGroup)
        {
            if (id != fitnessGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fitnessGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FitnessGroupExists(fitnessGroup.Id))
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
            return View(fitnessGroup);
        }

        // GET: FitnessGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessGroup = await _context.FitnessGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fitnessGroup == null)
            {
                return NotFound();
            }

            return View(fitnessGroup);
        }

        // POST: FitnessGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fitnessGroup = await _context.FitnessGroups.FindAsync(id);
            _context.FitnessGroups.Remove(fitnessGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FitnessGroupExists(int id)
        {
            return _context.FitnessGroups.Any(e => e.Id == id);
        }
    }
}
