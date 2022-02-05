using Microsoft.AspNetCore.Mvc;

namespace MariaMorales.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View("Posgrado");
        }
    }
}
