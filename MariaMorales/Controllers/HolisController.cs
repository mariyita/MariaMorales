using Microsoft.AspNetCore.Mvc;

namespace MariaMorales.Controllers
{
    public class HolisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
