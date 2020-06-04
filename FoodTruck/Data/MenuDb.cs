using FoodTruck.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruck.Data
{
    public class MenuDb
    {

        public static async Task<List<FoodItem>> GetFoodItems(ApplicationDbContext context)
        {
            List<FoodItem> f = await (from FoodItem in context.FoodItem
                                      select FoodItem).ToListAsync();
            return f;

        }

        public static async Task<FoodItem> Add(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            await context.SaveChangesAsync();

            return food;
        }

        public async static Task Delete(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            context.Entry(food).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        public static async Task<FoodItem> GetFoodItemById(int id, ApplicationDbContext context)
        {
            FoodItem food = await (from FoodItem in context.FoodItem
                                   where FoodItem.ItemID == id
                                   select FoodItem).SingleOrDefaultAsync();

            return food;
        }

        public static async Task<Reservation> GetReservationById(int id, ApplicationDbContext context)
        {
            Reservation reservation = await (from Reservation in context.Reservations
                                   where Reservation.ReservationId == id
                                   select Reservation).SingleOrDefaultAsync();

            return reservation;
        }

        public static async Task<FoodItem> Edit(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            context.Entry(food).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return food;
        }


        public static async Task<Reservation> Add(Reservation res, ApplicationDbContext context)
        {
            await context.AddAsync(res);
            await context.SaveChangesAsync();
            return res;
        }

        public async static Task Delete(Reservation res, ApplicationDbContext context)
        {
            await context.AddAsync(res);
            context.Entry(res).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }
    }
}
