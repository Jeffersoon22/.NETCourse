using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tutprial_1.Models;
using tutprial_1.Repository;

namespace tutprial_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataRepository _dataRepository;

        public UserController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _dataRepository.GetUsers();
        }

        [HttpGet]
        [Route("{id}")]
        public User Get(int id)
        {
            return _dataRepository.GetUser(id);
        }

        [HttpPost]
        public User Post([FromForm] User user)
        {
            var result = _dataRepository.Add(user);
            return result;
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
           var result =  _dataRepository.Delete(id);
            
            if(result)
            {
                return Ok();
            }

            return BadRequest();

        }
    }
}