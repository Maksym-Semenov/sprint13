using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Tasks.Models;

namespace Tasks.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }
        public IActionResult ProductInfo()
        {
            List <Product> products = new List<Product>();
            Product product1 = new Product("Bread", 10);
            Product product2 = new Product("Milk", 11);
            Product product3 = new Product("Cheese", 140);
            Product product4 = new Product("Sausage", 110);
            Product product5 = new Product("Potato", 7);
            Product product6 = new Product("Banana", 23);
            Product product7 = new Product("Tomato", 25);
            Product product8 = new Product("Candy", 75);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);

            return View(products);
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
