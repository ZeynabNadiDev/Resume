using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Infrastructure;

namespace Resume.Application.Services.Implementation
{
    public class EducationServices : IEducationService 
    {
        private ResumeDbContext _context;

        public EducationServices(ResumeDbContext context)
        {
            _context = context;
        }
        public async Task<List<Education>> GetListOfEducations()
        {
            return await _context.Educations.ToListAsync();
        }

        public async Task CreateAnEducation(Education education)
        {
            await _context.Educations.AddAsync(education);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnEducation(int educationId)
        {
            Education education = await GetAnEducationByIdAsync(educationId);
            if (education != null)
            {
                _context.Educations.Remove(education);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Education> GetAnEducationByIdAsync(int educationId)
        {
            return await _context.Educations
                                 .FirstOrDefaultAsync(p => p.Id == educationId);
        }
    }
}
