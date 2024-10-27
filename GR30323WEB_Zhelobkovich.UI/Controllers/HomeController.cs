using Microsoft.AspNetCore.Mvc;

namespace GR30323WEB_Zhelobkovich.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
