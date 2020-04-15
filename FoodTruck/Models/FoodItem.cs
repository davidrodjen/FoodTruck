using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Models
{
    public class FoodItem
    {


        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public double Price { get; set; }

        public string Descrip { get; set; }

        public int Calories { get; set; }

        public bool Vegan { get; set; }


    }
}
