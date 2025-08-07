using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Domain.Entities.ContacUs;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;

namespace Resume.presentation.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsRepository _contactUsRepository;
        public ContactUsController(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }


       public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> ContactUs(ContactUsDTO contactUsDTO)
        {
            ContactUs contact = new ContactUs()
            {
                FullName = contactUsDTO.FullName,
                Email = contactUsDTO.Email,
                Message = contactUsDTO.Message

            };
            ContactUsLocation location = new ContactUsLocation()
            {
                Address = contactUsDTO.Address
            };
   
            await _contactUsRepository.AddContactUsToTheDataBase(contact);
            await _contactUsRepository.AddLocationToTheDataBase(location);
            return View();
        }

    }
}
