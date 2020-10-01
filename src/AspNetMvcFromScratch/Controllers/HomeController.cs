using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcFromScratch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
