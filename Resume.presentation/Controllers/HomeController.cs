using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Education;
using Resume.Infrastructure;

using Resume.Domain.Entities.Expeience;
using Resume.Domain.Entities.MySkills;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.RepositoryInterface;
using Resume.Application.Services.Interface;


namespace Resume.presentation.Controllers;

public class HomeController : Controller
{
    private readonly IDashbordService _dashbordService;
    public HomeController(IDashbordService dashbordService)
    {
        _dashbordService = dashbordService;
    }

    public async Task<IActionResult> Index()
    {
        var model = await _dashbordService.FillDashbordModel();
        return View(model);
    }
   
}
