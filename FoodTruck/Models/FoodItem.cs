using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    public class FoodItem
    {

        [Key]
        [Required]
        public int ItemID { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Descrip { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public bool Vegan { get; set; }


    }
}
