using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneMarket.API.Models
{
    public class DroneModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int MaxFlightRadius { get; set; }

        [Required]
        public bool HasWifiOrBluetooth { get; set; }
    }
}
