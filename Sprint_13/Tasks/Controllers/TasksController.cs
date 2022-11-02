using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class TasksController : Controller
    {
        public List<string> markets = new List<string>() {"WellMart", "Silpo", "ATB", "Furshet", "Metro"};

        public Dictionary<string, int> shoppingList = new Dictionary<string, int>
        {
            ["Milk"] = 2,
            ["Bread"] = 2,
            ["Cake"] = 1,
            ["Ice Cream"] = 5,
            ["Cola"] = 10
        };

        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult ProductInfo()
        {
            return View();
        }

        public IActionResult SuperMarkets()
        {
            ViewBag.Markets = markets;
            return View();
        }

        public IActionResult ShoppingList()
        {
            return View(shoppingList);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            ViewBag.Markets = markets;
            ViewBag.ShoppingList = shoppingList;
            DateTime today = DateTime.Today;
            ViewBag.Today = new DateTime(today.Year, today.Month, today.Day);
            ViewBag.Tomorrow = new DateTime(today.Year, today.Month, today.Day).AddDays(1);
            ViewBag.DayAfterTomorrow = new DateTime(today.Year, today.Month, today.Day).AddDays(2);

            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(string fullName, string address)
        {
            return Content($"Your product will be shipped at: {address}. Bon appetite, {fullName}!");
        }

        public IActionResult TimeToBuy()
        {
            return PartialView();
        }
    }
}
