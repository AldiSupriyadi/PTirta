using Microsoft.AspNetCore.Mvc;

namespace PTirta.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
