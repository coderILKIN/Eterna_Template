using Eterna_Template.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna_Template.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Card> Cards { get; set;}

        public DbSet<Setting> Settings { get; set; }

    }
}
