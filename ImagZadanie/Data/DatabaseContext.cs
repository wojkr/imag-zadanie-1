using ImagZadanie.Models;
using Microsoft.EntityFrameworkCore;

namespace ImagZadanie.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
