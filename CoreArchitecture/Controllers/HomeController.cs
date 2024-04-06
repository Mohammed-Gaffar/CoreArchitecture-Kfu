using Microsoft.AspNetCore.Mvc;

namespace CoreArchitecture.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
