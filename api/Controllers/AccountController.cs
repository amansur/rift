using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rift.Data;
using Microsoft.EntityFrameworkCore;
using rift.Models;

namespace rift.Controllers
{

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApiContext _context;

        public UserController(ApiContext context)
        {
            _context = context;
        }

        // GET api/user
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.User.ToListAsync();
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _context.User.FindAsync(id);
        }

        // POST api/user
        [HttpPost]
        public async Task<bool> Post([FromBody]User value)
        {
            await _context.User.AddAsync(value);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody]User value)
        {
            var rec = await _context.User.FindAsync(id);
            rec = value;
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            var rec = await _context.User.FindAsync(id);
            _context.User.Remove(rec);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }
    }
}
