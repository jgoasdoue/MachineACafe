using MachineACafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MachineACafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        // Called on form submit to validate the chosen drink and display the price (if the drink is valid)
        [HttpPost]
        public IActionResult Index(object sender, EventArgs e)
        {
            Drink drink = null;

            ViewBag.Error = "";

            switch (Request.Form["drink"]){
                case "Expresso":
                    drink = new Expresso();
                    break;
                case "Allonge":
                    drink = new Allonge();
                    break;
                case "Capuccino":
                    drink = new Capuccino();
                    break;
                case "Chocolat":
                    drink = new Chocolat();
                    break;
                case "The":
                    drink = new The();
                    break;
                default:
                    ViewBag.Error = "Erreur: Boison non reconnue";
                    break;

            }

            ViewBag.Price = drink != null ? string.Format("{0:F2}",drink.getPrice()):"";

            return View("Index");
        }
    }
}
