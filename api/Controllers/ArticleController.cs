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
    public class ArticleController : Controller
    {
        private readonly ApiContext _context;

        public ArticleController(ApiContext context)
        {
            _context = context;
        }

        // GET api/article
        [HttpGet]
        public async Task<IEnumerable<Article>> Get()
        {
            return await _context.Article.ToListAsync();
        }

        // GET api/article/5
        [HttpGet("{id}")]
        public async Task<Article> Get(int id)
        {
            return await _context.Article.FindAsync(id);
        }

        // POST api/article
        [HttpPost]
        public async Task<bool> Post([FromBody]Article value)
        {
            await _context.Article.AddAsync(value);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        // PUT api/article/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody]Article value)
        {
            var rec = await _context.Article.FindAsync(id);
            rec = value;
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }

        // DELETE api/c/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            var rec = await _context.Article.FindAsync(id);
            _context.Article.Remove(rec);
            var count = await _context.SaveChangesAsync();
            return count > 0;
        }
    }
}
