using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QrOrderCustomerApi.Data;
using QrOrderCustomerApi.Entities;
using QrOrderCustomerApi.Requests;

namespace QrOrderCustomerApi.Controllers
{
    [Route("customer/[controller]")]
    [ApiController]
    public class OrderController(ILogger<OrderController> logger, DataContext context) : ControllerBase
    {
        private readonly ILogger<OrderController> _logger = logger;
        private readonly DataContext _context = context;

        [HttpGet(Name = "GetAllRestaurants")]
        public async Task<ActionResult<List<Restaurant>>> GetAllRestaurants()
        {
            var restaurants = await _context.Restaurants.ToListAsync();
            return Ok(restaurants);
        }

        [HttpGet("{id}", Name = "GetRestaurantById")]
        public async Task<ActionResult<Restaurant>> GetRestaurantById(long id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant is null)
            {
                return NotFound("Restaurant not found");
            }

            return Ok(restaurant);
        }

        [HttpPost(Name = "CreateRestaurant")]
        public async Task<ActionResult<Restaurant>> CreateRestaurant(CreateRestaurant request)
        {
            var restaurant = new Restaurant
            {
                RestaurantTel = request.RestaurantTel
            };
            await _context.Restaurants.AddAsync(restaurant);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.RestaurantId }, restaurant);
        }

        [HttpPut("{id}", Name = "UpdateRestaurant")]
        public async Task<ActionResult<Restaurant>> UpdateRestaurant(long id, UpdateRestaurant request)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant is null)
            {
                return NotFound("Restaurant not found");
            }

            restaurant.RestaurantTel = request.RestaurantTel;

            await _context.SaveChangesAsync();
            return Ok(restaurant);
        }

        [HttpDelete("{id}", Name = "DeleteRestaurant")]
        public async Task<ActionResult> DeleteRestaurant(long id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant is null)
            {
                return NotFound("Restaurant not found");
            }

            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}