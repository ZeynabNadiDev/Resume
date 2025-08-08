using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.Entities.MySkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
    public interface IMySkillsService
    {
        Task<List<MySkills>> GetListOfMySkills();
    }
}
