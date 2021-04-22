using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Morgenmadsbuffeten.Data;
using Morgenmadsbuffeten.Models;
using Morgenmadsbuffeten.Models.ViewModel;

namespace Morgenmadsbuffeten.Controllers
{
    public class KitchensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KitchensController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize("IsKitchen")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info(DateTime datoInput)
        {
            ViewBag.Dato = datoInput.Date;
            Kitchen ViewModelKitchen = new Kitchen();
            ViewModelKitchen.Receptions = getReception(datoInput);
            ViewModelKitchen.Restaurants = getRestaurant(datoInput);

            return View(ViewModelKitchen);
        }

        private List<Reception> getReception(DateTime datoInput)
        {
            List<Reception> reception = new List<Reception>();

            foreach (var r in _context.Receptions)
            {
                if (r.CheckInDate.Date == datoInput.Date)
                {
                    reception.Add(r);
                }
            }


            return reception;
        }

        private List<Restaurant> getRestaurant(DateTime datoInput)
        {
            List<Restaurant> restaurant = new List<Restaurant>();

            foreach (var r in _context.Restaurants)
            {
                if (r.DateRightNow.Date == datoInput.Date)
                {
                    restaurant.Add(r);
                }
            }

            return restaurant;
        }

    }
}
