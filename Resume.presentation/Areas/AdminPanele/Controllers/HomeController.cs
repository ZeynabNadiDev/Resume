using Microsoft.AspNetCore.Mvc;

namespace Resume.presentation.Areas.AdminPanele.Controllers
{
    [Area("AdminPanele")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
