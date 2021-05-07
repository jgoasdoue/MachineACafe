using MachineACafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

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
            Drink drink;
            
            GetDrinkType(Request.Form["drink"], out drink);

            if(drink != null)
            {
                ViewBag.Price = string.Format("{0:F2}", drink.GetPrice());
                ViewBag.Error = "";
            }
            else
            {
                ViewBag.Price = "";
                ViewBag.Error = "Erreur: Boison non reconnue";
                _logger.LogError("Error: {0} is not a valid drink", Request.Form["drink"]);
            }

            return View("Index");
        }

        private static void GetDrinkType(string drinkName, out Drink drink)
        {
            switch (drinkName)
            {
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
                    drink = null;
                    break;
            }
        }
    }
}
