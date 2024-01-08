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
        [HttpPost]
        public IActionResult EditShop(int id, string name)
        {
            var shop = db.Shops.Find(id);

            if (shop == null)
            {
                return NotFound();
            }

            shop.Name = name;
            db.SaveChanges();

            return RedirectToAction("Viewshop");
        }

        [HttpPost]
        public IActionResult DeleteShop(int id)
        {
            var shop = db.Shops.Find(id);

            if (shop == null)
            {
                return NotFound();
            }

            db.Shops.Remove(shop);
            db.SaveChanges();

            return RedirectToAction("Viewshop");
        }

    }
}
