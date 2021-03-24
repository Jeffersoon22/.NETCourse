using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practices.Data;
using Practices.models;

namespace Practices.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ToysController : ControllerBase
    {
        private readonly JwtDbContext _context;

        public ToysController(JwtDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Toys>>> GetCars()
        {
            return await _context.Toy.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Toys>> GetToys(int id)
        {
            var toy = await _context.Toy.FindAsync(id);

            if (toy == null)
            {
                return NotFound();
            }

            return toy;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Toys toy)
        {
            if (id != toy.Id)
            {
                return BadRequest();
            }

            _context.Entry(toy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Toys>> PostCar(Toys toy)
        {
            _context.Toy.Add(toy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToys", new { id = toy.Id }, toy);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Toys>> DeleteToy(int id)
        {
            var toy = await _context.Toy.FindAsync(id);
            if (toy == null)
            {
                return NotFound();
            }

            _context.Toy.Remove(toy);
            await _context.SaveChangesAsync();

            return toy;
        }

        private bool ToyExists(int id)
        {
            return _context.Toy.Any(e => e.Id == id);
        }
    }
}
