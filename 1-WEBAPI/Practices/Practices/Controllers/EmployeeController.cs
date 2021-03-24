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
    public class EmployeeController : ControllerBase
    {

        private readonly CompanyDbContext _context;

        public EmployeeController(CompanyDbContext context)
        {
            _context = context;
        }



        // GET: api/Employee
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {

            var result = await _context.Employees.Include(x => x.Company).AsNoTracking().ToListAsync();
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(result, settings);
            return JsonConvert.DeserializeObject<List<Employee>>(json);
        }


        // GET: api/Employee/5
        [HttpGet]
        [Route("{Id}")]
        public async Task<Employee> Get(int id)
        {
            var result = await _context.Employees.Include(x => x.Company).AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(result, settings);
            return JsonConvert.DeserializeObject<Employee>(json);
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            _context.Add(emp);
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
