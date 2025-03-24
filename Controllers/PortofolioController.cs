using Microsoft.AspNetCore.Mvc;

namespace PTirta.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
