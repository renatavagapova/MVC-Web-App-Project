using Microsoft.AspNetCore.Mvc;
using MVC_Web_App_Project.Models;

namespace MVC_Web_App_Project.Controllers
{
    public class AddProductController : Controller
    {

        public AddProduct catalog;

        public AddProductController(AddProduct catalog)
        {
            this.catalog = catalog;
        }

        [HttpGet]
        public IActionResult AddProducts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProducts([FromForm] Category category)
        {
            catalog.Categories.Add(category);
            return View(catalog);
        }
    }
}
