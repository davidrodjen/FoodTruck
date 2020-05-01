using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public string EventName { get; set; }

        [Required]
        public int NumGuests { get; set; }

        [Required]
        public string PackageDescription { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}
