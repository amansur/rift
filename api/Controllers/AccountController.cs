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
    public class AccountController : Controller
    {
        private readonly ApiContext _context;

        public AccountController(ApiContext context)
        {
            _context = context;
        }

        // GET api/account
        [HttpGet]
        public async Task<IEnumerable<Article>> Get()
        {
            return await _context.Article.ToListAsync();
        }

        // GET api/account/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/account
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/account/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
