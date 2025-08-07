using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.Expeience;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
  public  class ExperienceRepository: IExperienceRepository
    {
        private readonly ResumeDbContext _context;

        public ExperienceRepository(ResumeDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Experience>> GetListOfExperience()
        {
            return await _context.Experiences
                                            .ToListAsync();
        }
    }
}
