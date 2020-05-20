using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTruck.Data;
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
        public IActionResult Add()
        {
            return View();
        }

    }
}