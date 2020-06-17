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
        /// <summary>
        /// Retrieve all Food Items
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<List<FoodItem>> GetFoodItems(ApplicationDbContext context)
        {
            List<FoodItem> f = await (from FoodItem in context.FoodItem
                                      select FoodItem).ToListAsync();
            return f;

        }
        /// <summary>
        /// Retrieve all reservations
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<List<Reservation>> GetReservations(ApplicationDbContext context)
        {
            List<Reservation> res = await (from Reservation in context.Reservations
                                           select Reservation).ToListAsync();
            return res;
        }

        /// <summary>
        /// Add a Food Item
        /// </summary>
        /// <param name="food"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<FoodItem> Add(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            await context.SaveChangesAsync();

            return food;
        }

        /// <summary>
        /// Edit a Food Item
        /// </summary>
        /// <param name="food"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<FoodItem> Edit(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            context.Entry(food).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return food;
        }

        /// <summary>
        /// Delete a Food Item
        /// </summary>
        /// <param name="food"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async static Task Delete(FoodItem food, ApplicationDbContext context)
        {
            await context.AddAsync(food);
            context.Entry(food).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Get a Food Item by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<FoodItem> GetFoodItemById(int id, ApplicationDbContext context)
        {
            FoodItem food = await (from FoodItem in context.FoodItem
                                   where FoodItem.ItemID == id
                                   select FoodItem).SingleOrDefaultAsync();

            return food;
        }

        /// <summary>
        /// Get a Reservation by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<Reservation> GetReservationById(int id, ApplicationDbContext context)
        {
            Reservation reservation = await (from Reservation in context.Reservations
                                   where Reservation.ReservationId == id
                                   select Reservation).SingleOrDefaultAsync();

            return reservation;
        }


        /// <summary>
        /// Add a new Reservation
        /// </summary>
        /// <param name="res"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<Reservation> Add(Reservation res, ApplicationDbContext context)
        {
            await context.AddAsync(res);
            await context.SaveChangesAsync();
            return res;
        }

        /// <summary>
        /// Edit a Reservation
        /// </summary>
        /// <param name="res"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task<Reservation> EditReservation(Reservation res, ApplicationDbContext context)
        {
            await context.AddAsync(res);
            context.Entry(res).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return res;
        }

        /// <summary>
        /// Delete a Reservation
        /// </summary>
        /// <param name="res"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async static Task DeleteReservation(Reservation res, ApplicationDbContext context)
        {
            await context.AddAsync(res);
            context.Entry(res).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }

    }
}
