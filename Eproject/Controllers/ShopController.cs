using Eproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eproject.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext db;

        public ShopController(ApplicationDbContext db) {
            this.db = db;
        } 
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Addshop()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addshop(shop model)
        {
            var shop = new shop()
            {
                Name = model.Name
            };
            db.Shops.Add(shop);
            db.SaveChanges();
            return RedirectToAction("Addshop");

        }
        public IActionResult Viewshop()
        {
            var getshops = db.Shops.ToList();
            return View(getshops);
        }
    }
}
