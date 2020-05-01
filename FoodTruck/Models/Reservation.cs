using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public string EventName { get; set; }

        public int NumGuests { get; set; }

        public string PackageDescription { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Address { get; set; }

        public double Price { get; set; }
    }
}
