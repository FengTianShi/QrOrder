using System.ComponentModel.DataAnnotations.Schema;
using NpgsqlTypes;

namespace QrOrderCustomerApi.Models
{
    [Table("t_restaurant")]
    public class Restaurant
    {
        public long RestaurantId { get; set; }
        // public long OwnerId { get; set; }
        // public long CurrencyId { get; set; }
        public string? RestaurantTel { get; set; }
        // public string? RestaurantPostalCode { get; set; }
        // public NpgsqlPoint RestaurantLongitude { get; set; }
        // public NpgsqlPoint RestaurantLatitude { get; set; }
        // public long RestaurantServiceRadius { get; set; }
        // public bool IsLimitServiceRadius { get; set; }
        // public bool IsLimitServiceTime { get; set; }
        // public string? WifiSsid { get; set; }
        // public string? WifiPassword { get; set; }
        // public bool IsInvalid { get; set; }
        // public bool IsDeleted { get; set; }
    }
}
