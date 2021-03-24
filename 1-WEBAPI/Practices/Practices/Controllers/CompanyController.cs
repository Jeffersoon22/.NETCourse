using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Practices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyDbContext _context;

        public CompanyController(CompanyDbContext context )
        {
            _context = context;
        }

        // GET: api/Company
        [HttpGet]
        public async Task<IEnumerable<Company>> Get()
        {

            var result = await _context.Companies.Include(x => x.Employees).AsNoTracking().ToListAsync();
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(result, settings);
            return JsonConvert.DeserializeObject<List<Company>>(json);
        }

        // GET: api/Company/5
        [HttpGet]
        [Route("{Id}")]

        public async Task<Company> Get(int Id)
        {
            var result = await _context.Companies.Include(x => x.Employees).AsNoTracking().SingleOrDefaultAsync(x => x.Id == Id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(result, settings);
            return JsonConvert.DeserializeObject<Company>(json);
        }

        // POST: api/Company
        [HttpPost]
        public void Post([FromBody] Company comp)
        {
            _context.Add(comp);
            _context.SaveChanges();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleted = Get(id);
            _context.Remove(deleted);
            _context.SaveChanges();

        }
    }
}
