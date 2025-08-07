using Resume.Domain.Entities.ContacUs;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly ResumeDbContext _resumeDbContext;

        public ContactUsRepository(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }
        public async Task AddContactUsToTheDataBase(ContactUs contactUs)
        {
            await _resumeDbContext.ContactUs.AddAsync(contactUs);
            await _resumeDbContext.SaveChangesAsync();

        }

        public async Task AddLocationToTheDataBase(ContactUsLocation location)
        {
            await _resumeDbContext.ContactUsLocation.AddAsync(location);
            await _resumeDbContext.SaveChangesAsync();
        }
    }
}
