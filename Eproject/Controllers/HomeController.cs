using Microsoft.AspNetCore.Mvc;
using Eproject.Models;

namespace Shopping_cart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)

        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var getshop = db.Shops.ToList();
            return View(getshop);
        }
    }
}
