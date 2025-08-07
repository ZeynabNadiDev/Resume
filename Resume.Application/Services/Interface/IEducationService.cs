using Resume.Domain.Entities.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
   public interface IEducationService
    {
        Task<List<Education>> GetListOfEducations();
        Task CreateAnEducation(Education education);
        Task DeleteAnEducation(int educationId);

        Task<Education> GetAnEducationByIdAsync(int educationId);
    }
}
