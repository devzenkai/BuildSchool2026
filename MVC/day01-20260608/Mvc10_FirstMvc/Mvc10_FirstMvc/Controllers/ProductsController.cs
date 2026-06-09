using Microsoft.AspNetCore.Mvc;
using Mvc10_FirstMvc.Models;

namespace Mvc10_FirstMvc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexModel()
        {
            Product car = new Product()
            {
                Id = 1529,
                Title = "Products",
                ProductName = "Ferrari",
                Url = "img/10-2015-488-gtb.jpg"
            };
            return View(car);
        }
    }
}
