using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Infrastructure;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
namespace Resume.presentation.Controllers
{
    public class EducationController : Controller
    {

        private readonly IEducationService _educationService;
         public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet]
        public async Task <IActionResult> ListOfEducations()
        {
            List<Education> educations = await _educationService.GetListOfEducations();
            return View(educations);
        }
        public async Task <IActionResult> CreateAnEducation()
        {
            return RedirectToAction(nameof(ListOfEducations));

        }
        public async Task<IActionResult> DeleteAnRecored(int educationId)
        {

            return RedirectToAction(nameof(ListOfEducations));
        }
    }
}
