using System.ComponentModel.DataAnnotations;

namespace QrOrderCustomerApi.Requests
{
    public class CreateRestaurant
    {
        [Required]
        public string RestaurantTel { get; set; } = string.Empty;
    }
}
