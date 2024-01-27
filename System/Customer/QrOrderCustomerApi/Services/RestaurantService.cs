using QrOrderCustomerApi.Data;
using QrOrderCustomerApi.Models;

namespace QrOrderCustomerApi.Services
{
    public class RestaurantService(ILogger<RestaurantService> logger, QrOrderDbContext context)
    {
        private readonly ILogger<RestaurantService> _logger = logger;
        private readonly QrOrderDbContext _context = context;

        public List<Restaurant> GetRestaurants()
        {
            return [.. _context.Restaurants];
        }
    }
}