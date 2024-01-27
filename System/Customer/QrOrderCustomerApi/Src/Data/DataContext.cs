using Microsoft.EntityFrameworkCore;
using QrOrderCustomerApi.Entities;

namespace QrOrderCustomerApi.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}