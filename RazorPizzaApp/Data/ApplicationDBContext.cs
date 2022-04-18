using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        // Shortcut Constructor = ctor tab tab
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> 
            options) : base(options)
        {

        }
    }
}
