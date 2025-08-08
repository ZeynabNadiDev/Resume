using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
    public class MySkillsService: IMySkillsService
    {
        private readonly IMySkillsRepository _mySkillsRepository;
        public MySkillsService(IMySkillsRepository mySkillsRepository)
        {
            _mySkillsRepository = mySkillsRepository;
        }

        public async Task<List<MySkills>> GetListOfMySkills()
        {
           return await _mySkillsRepository.GetListOfMySkills();
           
        }
    }
}
