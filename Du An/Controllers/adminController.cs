using Microsoft.AspNetCore.Mvc;

namespace Du_An.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
