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
    public class MembersController : Controller
    {
        private readonly GymDbContext _context;

        public MembersController(GymDbContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            return View(await _context.Members.ToListAsync());
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            member.Payments = await _context.Payments.Where(x => x.MemberId == member.Id).ToListAsync();
            member.FitnessAndMembers = await _context.FitnessAndMembers
                .Include(x=>x.FitnessGroup)
                .Where(x =>x.MemberId == member.Id)
                .ToListAsync();
            return View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Phone,Email,BirthDate")] Member member)
        {
            if (ModelState.IsValid)
            {
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Phone,Email,BirthDate")] Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
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
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }
        public async Task<IActionResult> InactiveMembers()
        {
            var members = await _context.Members.ToListAsync();
            List<Member> inactiveMembers = new List<Member>();
            foreach (var member in members)
            {
                var payments = await _context.Payments.Where(x => x.MemberId == member.Id).ToListAsync();
                if (payments.Count() == 0)
                {
                    inactiveMembers.Add(member);
                }
                else
                {
                    decimal totalPayedAmoun = 0;
                    double daysPassed = 0;
                    for (int i = 1; i < payments.Count(); i++)
                    {
                        daysPassed += (payments.ElementAt(i).Date - payments.ElementAt(i - 1).Date).TotalDays;
                        totalPayedAmoun += payments.ElementAt(i - 1).Amount;
                        if ((decimal)daysPassed > totalPayedAmoun / 2)
                        {
                            daysPassed = 0;
                            totalPayedAmoun = 0;
                        }
                    }
                    daysPassed += (DateTime.Now - payments.Last().Date).TotalDays;
                    totalPayedAmoun += payments.Last().Amount;
                    if ((decimal)daysPassed > totalPayedAmoun / 2)
                    {
                        inactiveMembers.Add(member);
                    }
                }
            }
            return View(inactiveMembers);
        }
        public async Task<IActionResult> Exclude(int? id)
        {
            var excluded = await _context.FitnessAndMembers.Where(x => x.MemberId == id).ToListAsync();
            _context.RemoveRange(excluded);
            await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

        }


        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Members.FindAsync(id);
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }
    }
}
