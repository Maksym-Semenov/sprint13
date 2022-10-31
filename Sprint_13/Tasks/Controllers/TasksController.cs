using Microsoft.AspNetCore.Mvc;

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
