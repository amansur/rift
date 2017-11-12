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
    public class TopicController : Controller
    {
        private readonly ApiContext _context;

        public TopicController(ApiContext context)
        {
            _context = context;
        }

        // GET api/topic
        [HttpGet]
        public async Task<IEnumerable<Topic>> Get()
        {
            return await _context.Topic.ToListAsync();
        }

        // GET api/topic/5
        [HttpGet("{id}")]
        public async Task<Topic> Get(int id)
        {
            return await _context.Topic.FindAsync(id);
        }

        // POST api/topic
        [HttpPost]
        public async Task<bool> Post([FromBody]Topic value)
        {
            await _context.Topic.AddAsync(value);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        // PUT api/topic/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody]Topic value)
        {
            var rec = await _context.Topic.FindAsync(id);
            rec = value;
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        // DELETE api/topic/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            var rec = await _context.Topic.FindAsync(id);
            _context.Topic.Remove(rec);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }
    }
}
