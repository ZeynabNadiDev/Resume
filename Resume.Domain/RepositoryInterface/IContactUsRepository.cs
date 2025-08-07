using Resume.Domain.Entities.ContacUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
    public interface IContactUsRepository
    {
       Task AddContactUsToTheDataBase(ContactUs contactUs);
    }
}
