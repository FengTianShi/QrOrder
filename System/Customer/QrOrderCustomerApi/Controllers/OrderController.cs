using Microsoft.AspNetCore.Mvc;
using QrOrderCustomerApi.Models;
using QrOrderCustomerApi.Services;

namespace QrOrderCustomerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(ILogger<OrderController> logger, RestaurantService restaurantService) : ControllerBase
{
    private readonly ILogger<OrderController> _logger = logger;
    private readonly RestaurantService _restaurantService = restaurantService;

    [HttpGet(Name = "GetRestaurant")]
    public IEnumerable<Restaurant> Get()
    {
        return _restaurantService.GetRestaurants();
    }
}
