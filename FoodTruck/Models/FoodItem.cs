using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    public class FoodItem
    {
        /// <summary>
        /// Unique Identifier for menu item
        /// </summary>
        [Key]
        public int ItemID { get; set; }

        /// <summary>
        /// Item name required, includes error message
        /// EX: "Cheeseburger"
        /// </summary>
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30)]
        public string ItemName { get; set; }

        /// <summary>
        /// Price required, includes error message
        /// EX: "5.99"
        /// </summary>
        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [Range(0.0, 200.0)]
        public double Price { get; set; }

        /// <summary>
        /// Description required, includes error message
        /// EX: "This is a burger with a cheesy explosion"
        /// </summary>
        [Required(ErrorMessage = "Description is required")]
        [StringLength(400)]
        public string Description { get; set; }

        /// <summary>
        /// Calorie count, not required, but suggested for diet
        /// </summary>
        [Range(0, 2000)]
        public int Calories { get; set; }

        /// <summary>
        /// Vegan bool, not required, but suggested for diet
        /// </summary>
        [DefaultValue(false)]
        public bool Vegan { get; set; }


    }
}
