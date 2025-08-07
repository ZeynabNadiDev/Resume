using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.MySkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
  public interface IMySkillsRepository
    {
      Task<List<MySkills>> GetListOfMySkills();
    }
}
