using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContacUs;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;

namespace Resume.presentation.Controllers
{
    public class ContactUsController : Controller
    {
    private readonly IContactUsServices _contactUsServices;
        public ContactUsController(IContactUsServices contactUsServices)
        {
            _contactUsServices = contactUsServices;
        }


       public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public async Task <IActionResult> ContactUs(ContactUsDTO contactUsDTO)
        {
            if (ModelState.IsValid)
            {
                await _contactUsServices.AddNewContactUsMessage(contactUsDTO);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}
