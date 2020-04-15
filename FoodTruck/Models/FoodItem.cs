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
        public int ItemID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30)]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [Range(0.0, 200.0)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(400)]
        public string Descrip { get; set; }

        [Range(0, 2000)]
        public int Calories { get; set; }

        public bool Vegan { get; set; }


    }
}
