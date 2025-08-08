using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Expeience;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
    public class ExperienceService: IExperienceService
    {
        private readonly IExperienceRepository _experienceRepository;
        public ExperienceService(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

      public async Task<List<Experience>> GetListOfExperience()
        {
            return await _experienceRepository.GetListOfExperience();
        }
    }
}
