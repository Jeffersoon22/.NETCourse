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
    public class FitnessAndMembersController : Controller
    {
        private readonly GymDbContext _context;

        public FitnessAndMembersController(GymDbContext context)
        {
            _context = context;
        }

        // GET: FitnessAndMembers
        public async Task<IActionResult> Index()
        {
            var gymDbContext = _context.FitnessAndMembers.Include(f => f.FitnessGroup).Include(f => f.Member);
            return View(await gymDbContext.ToListAsync());
        }

        // GET: FitnessAndMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessAndMembers = await _context.FitnessAndMembers
                .Include(f => f.FitnessGroup)
                .Include(f => f.Member)
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (fitnessAndMembers == null)
            {
                return NotFound();
            }

            return View(fitnessAndMembers);
        }

        // GET: FitnessAndMembers/Create
        public IActionResult Create()
        {
            ViewData["FitId"] = new SelectList(_context.FitnessGroups, "Id", "Name");
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name");
            return View();
        }

        // POST: FitnessAndMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FitId,MemberId")] FitnessAndMembers fitnessAndMembers)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(fitnessAndMembers);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["FitId"] = new SelectList(_context.FitnessGroups, "Id", "Name", fitnessAndMembers.FitId);
                ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", fitnessAndMembers.MemberId);
                return View(fitnessAndMembers);
            }
            catch (Exception)
            {

                return View("InvalidCreate");
            }
        }

        // GET: FitnessAndMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessAndMembers = await _context.FitnessAndMembers.FindAsync(id);
            if (fitnessAndMembers == null)
            {
                return NotFound();
            }
            ViewData["FitId"] = new SelectList(_context.FitnessGroups, "Id", "Name", fitnessAndMembers.FitId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", fitnessAndMembers.MemberId);
            return View(fitnessAndMembers);
        }

        // POST: FitnessAndMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FitId,MemberId")] FitnessAndMembers fitnessAndMembers)
        {
            if (id != fitnessAndMembers.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fitnessAndMembers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FitnessAndMembersExists(fitnessAndMembers.MemberId))
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
            ViewData["FitId"] = new SelectList(_context.FitnessGroups, "Id", "Name", fitnessAndMembers.FitId);
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Name", fitnessAndMembers.MemberId);
            return View(fitnessAndMembers);
        }

        // GET: FitnessAndMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessAndMembers = await _context.FitnessAndMembers
                .Include(f => f.FitnessGroup)
                .Include(f => f.Member)
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (fitnessAndMembers == null)
            {
                return NotFound();
            }

            return View(fitnessAndMembers);
        }

        // POST: FitnessAndMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fitnessAndMembers = await _context.FitnessAndMembers.FindAsync(id);
            _context.FitnessAndMembers.Remove(fitnessAndMembers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FitnessAndMembersExists(int id)
        {
            return _context.FitnessAndMembers.Any(e => e.MemberId == id);
        }
    }
}
