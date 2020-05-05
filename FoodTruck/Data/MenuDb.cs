using FoodTruck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Data
{
    public class MenuDb
    {



        public static async Task<FoodItem> Add(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            await context.SaveChangesAsync();

            return food;
        }
    }
}
