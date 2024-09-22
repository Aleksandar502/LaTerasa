
using System.Threading.Tasks.Sources
using BackEnd.Core.Models;
using Core.Models;
using Microsoft.EntityFrameworkCore;
namespace BackEnd.Data
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Food> Food { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        
    }
}
