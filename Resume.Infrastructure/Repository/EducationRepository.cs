using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Resume.Domain.Entities.Education;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
    public class EducationRepository:IEducationRepository
    {
        private readonly ResumeDbContext _context;

        public EducationRepository(ResumeDbContext context)
        {
            _context = context;
        }

      public async Task<List<Education>>  GetListOfEducation()
        {
             return await _context.Educations
                          .ToListAsync();
        }
    }
}
