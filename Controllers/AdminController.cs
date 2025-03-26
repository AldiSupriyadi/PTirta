using Microsoft.AspNetCore.Mvc;

namespace PTirta.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
