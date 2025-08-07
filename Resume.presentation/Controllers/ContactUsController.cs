using Microsoft.AspNetCore.Mvc;
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
        public async Task <IActionResult> ContactUs(string fullName,string email,string message)
        {
            ContactUs model = new ContactUs()
            {
                FullName = fullName,
                Email = email,
                Message = message,
                CreateDate = DateTime.Now,
                IsSeenByAdmin=false
            };
            await _contactUsRepository.AddContactUsToTheDataBase(model);
            return View();
        }

    }
}
