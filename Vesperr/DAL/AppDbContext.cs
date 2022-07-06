using Microsoft.EntityFrameworkCore;
using Vesperr.Models;

namespace Vesperr.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Services> Services { get; set; }

    }
}
