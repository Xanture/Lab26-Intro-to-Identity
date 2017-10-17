using Microsoft.AspNetCore.Mvc;

namespace lab26_brian.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
