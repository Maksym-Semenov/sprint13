using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Tasks.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Supermarkets()
        {
            ViewBag.Markets = new List<string>() {"WellMart", "Silpo", "ATB", "Furshet", "Metro"};
            return View();
        }
        public IActionResult ShoppingList()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Milk", 2);
            dict.Add("Bread", 2);
            dict.Add("Cake", 1);
            dict.Add("Ice Cream", 5);
            dict.Add("Cola", 10);
            return View(dict);
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult TimeToBuy()
        {
            return PartialView("_TimeToBuy");
        }

        public IActionResult SprintTasks()
        {
            return View();
        }
    }
}
