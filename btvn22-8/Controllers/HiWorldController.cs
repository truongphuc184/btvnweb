using Microsoft.AspNetCore.Mvc;

namespace btvnweb.Controllers
{
    public class HiWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
    }
}
