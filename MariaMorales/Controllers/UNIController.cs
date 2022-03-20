using Microsoft.AspNetCore.Mvc;

namespace MariaMorales.Controllers
{
    public class UNIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //hik
        public IActionResult Test()
        {
            return View("Posgrado");
        }
    }
}
