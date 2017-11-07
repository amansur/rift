using Microsoft.EntityFrameworkCore;

namespace rift 
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
    }
}