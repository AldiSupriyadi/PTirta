using Microsoft.AspNetCore.Mvc;

namespace PTirta.Controllers
{
    public class PortofolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
