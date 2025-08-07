using Microsoft.EntityFrameworkCore;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
   public class MySkillsRepository : IMySkillsRepository
    {
        private readonly ResumeDbContext _context;

        public MySkillsRepository(ResumeDbContext context)
        {
            _context = context;
        }

      

        public async Task<List<MySkills>> GetListOfMySkills()
        {
            return await _context.MySkills
                                       .ToListAsync();
        }
    }
}
