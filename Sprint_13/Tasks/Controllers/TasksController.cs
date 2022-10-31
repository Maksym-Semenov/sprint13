using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Tasks.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Greeting()
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
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}
