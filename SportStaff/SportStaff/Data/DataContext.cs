using Microsoft.EntityFrameworkCore;
using SportStaff.Models;

namespace SportStaff.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Item> items { get; set; }
        public DbSet<Sale> sales { get; set; }


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
    }
}
