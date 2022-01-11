using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Views.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
