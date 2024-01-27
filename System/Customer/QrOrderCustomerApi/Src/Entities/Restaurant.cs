using System.ComponentModel.DataAnnotations.Schema;

namespace QrOrderCustomerApi.Entities
{
    [Table("t_restaurant")]
    public class Restaurant
    {
        [Column("restaurant_id")]
        public long RestaurantId { get; set; }

        // public long OwnerId { get; set; }
        // public long CurrencyId { get; set; }

        [Column("restaurant_tel")]
        public string RestaurantTel { get; set; } = string.Empty;

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
