using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTruck.Data;
using FoodTruck.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context; // Only constructor can edit

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> FoodTruckReservation()
        {
            ViewBag.ReservationBag = await MenuDb.GetReservations(_context);

            return View();
        }

        [HttpGet]
        public IActionResult AddReservation()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddReservation(Reservation res)
        {
            if (ModelState.IsValid)
            {
                await MenuDb.Add(res, _context);
                TempData["Message"] = $"{res.EventName} added successfully";
                // Had to redirect forcefully to the main menu for food truck
                return RedirectToAction("FoodTruckReservation", "Reservation");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Reservation res = await MenuDb.GetReservationById(id, _context);

            if (res == null)
            {
                return NotFound();
            }

            return View(res);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Reservation res = await MenuDb.GetReservationById(id, _context);
            await MenuDb.DeleteReservation(res, _context);
            TempData["Message"] = $"{res.EventName} deleted successfully";
            return RedirectToAction("FoodTruckReservation", "Reservation");
        }

    }
}