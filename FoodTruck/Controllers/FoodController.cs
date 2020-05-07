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
        public IActionResult FoodTruckMenu()
        {
            List<FoodItem> foods = new List<FoodItem>();
            return View(foods);
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

    }
}