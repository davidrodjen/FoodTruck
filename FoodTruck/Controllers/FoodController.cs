using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTruck.Data;
using FoodTruck.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{



    public class FoodController : Controller
    {

        private readonly ApplicationDbContext _context; // Only constructor can edit

        public FoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> FoodTruckMenu()
        {
            ViewBag.FoodBag = await MenuDb.GetFoodItems(_context);

            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(FoodItem food)
        {
            if (ModelState.IsValid)
            {
                await MenuDb.Add(food, _context);
                TempData["Message"] = $"{food.ItemName} added successfully";
                return RedirectToAction(nameof(FoodTruckMenu));
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            FoodItem food = await MenuDb.GetFoodItemById(id, _context);

            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            FoodItem food = await MenuDb.GetFoodItemById(id, _context);
            await MenuDb.Delete(food, _context);
            TempData["Message"] = $"{food.ItemName} deleted successfully";
            return RedirectToAction(nameof(FoodTruckMenu));
        }

    }
}