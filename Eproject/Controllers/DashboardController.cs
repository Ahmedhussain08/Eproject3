using Microsoft.AspNetCore.Mvc;

namespace Eproject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult dashboard()
        {
            return View();
        }
    }
}
