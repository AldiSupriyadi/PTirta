using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PTirta.Models;

namespace PTirta.Data
{
    public class PTirtaContext : IdentityDbContext<Users>
    {
        public PTirtaContext(DbContextOptions options) : base(options)
        {
        }

        protected PTirtaContext()
        {
        }
    }
}
