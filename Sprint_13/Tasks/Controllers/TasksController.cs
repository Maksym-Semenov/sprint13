using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

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

        public IActionResult Greetings()
        {
            return View();
        }
        public IActionResult Products()
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
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult TimeToBuy()
        {
            return PartialView();
        }

        public IActionResult SprintTasks()
        {
            return View();
        }
    }
}
