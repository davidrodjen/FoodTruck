using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    public class Reservation
    {
        /// <summary>
        /// Unique Identifier for a single reservation
        /// </summary>
        [Key]
        public int ReservationId { get; set; }

        /// <summary>
        /// The name of the event. Ex: Maggie's Birthday
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// The number of guests that will be fed
        /// </summary>
        [Required]
        public int NumGuests { get; set; }

        /// <summary>
        /// The description of the food package
        /// </summary>
        [Required]
        public string PackageDescription { get; set; }

        /// <summary>
        /// The date and time of the event 
        /// </summary>
        [Required]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// The address of the event
        /// </summary>
        [Required]
        public string Location { get; set; }

        /// <summary>
        /// The price for the reservation. Calculated per person
        /// </summary>
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}
