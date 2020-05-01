using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{
    public class FoodController : Controller
    {

        public IActionResult FoodTruckMenu()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

    }
}