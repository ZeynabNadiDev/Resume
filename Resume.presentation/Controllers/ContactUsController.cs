using Microsoft.AspNetCore.Mvc;

namespace Resume.presentation.Controllers
{
    public class ContactUsController : Controller
    {
       public IActionResult ContactUs()
        {
            return View();
        }
    }
}
