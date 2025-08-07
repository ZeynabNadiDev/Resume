using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Education;
using Resume.Infrastructure;
using Resume.presentation.Models;
using Resume.Domain.Entities.Expeience;
using Resume.Domain.Entities.MySkills;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.RepositoryInterface;


namespace Resume.presentation.Controllers;

public class HomeController : Controller
{
    private readonly IEducationRepository _educationRepository;
    private readonly IExperienceRepository _experienceRepository;
    private readonly IMySkillsRepository _mySkillsRepository;

    public HomeController(IEducationRepository educationRepository, IExperienceRepository experienceRepository, IMySkillsRepository mySkillsRepository)
    {
        _educationRepository = educationRepository;
        _experienceRepository = experienceRepository;
        _mySkillsRepository = mySkillsRepository;
    }

    public async Task<IActionResult> Index()
    {
        List<MySkills> mySkills = await _mySkillsRepository.GetListOfMySkills();

        List<Education> educations = await _educationRepository.GetListOfEducation();

        List<Experience> experiences = await _experienceRepository.GetListOfExperience();


        HomeIndexModelDTO model = new HomeIndexModelDTO();

        model.Experiences = experiences;
        model.Educations = educations;
        model.MySkills = mySkills;

        return View(model);
    }
   
}
