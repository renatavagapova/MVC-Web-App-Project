using Microsoft.AspNetCore.Mvc;
using MVC_Web_App_Project.Models;

namespace MVC_Web_App_Project.Controllers
{
    public class CatalogController : Controller
    {
        public AddProduct catalog;

        public CatalogController(AddProduct catalog)
        {
            this.catalog = catalog;
        }

        public IActionResult Categories(Category category)
        {
            return View(catalog);
        }


    }
}
