using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContacUs;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
    public class ContactUsServices:IContactUsServices
    {
        private readonly IContactUsRepository _contactUsRepository;
        public ContactUsServices(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }

        async Task IContactUsServices.AddNewContactUsMessage(ContactUsDTO contactUsDTO)
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
          
        }
    }
}
