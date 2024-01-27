using Microsoft.EntityFrameworkCore;
using QrOrderCustomerApi.Models;

namespace QrOrderCustomerApi.Data
{
    public class QrOrderDbContext(DbContextOptions<QrOrderDbContext> options) : DbContext(options)
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}