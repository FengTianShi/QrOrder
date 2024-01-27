using System.ComponentModel.DataAnnotations;

namespace QrOrderCustomerApi.Requests
{
    public class UpdateRestaurant
    {
        [Required]
        public string RestaurantTel { get; set; } = string.Empty;
    }
}
