#region Using
using Microsoft.AspNetCore.Mvc;

namespace Resume.presentation.Controllers;
#endregion

    public class AdminController : Controller
    {
    #region Admin Dashboard

    [HttpGet]
    public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public IActionResult Index(string Email,string Username )
    {
        return View();
    }
    #endregion
}


