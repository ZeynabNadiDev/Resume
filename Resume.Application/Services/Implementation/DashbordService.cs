using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Expeience;
using Resume.Domain.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementation
{
    public class DashbordService:IDashbordService
    {
        private readonly IEducationService _educationService;
        private readonly IExperienceService _experienceService;
        private readonly IMySkillsService _mySkillsService;

        public DashbordService(IEducationService educationService, IExperienceService experienceServic, IMySkillsService mySkillsService)
        {
            _educationService = educationService;
            _experienceService = experienceServic;
            _mySkillsService = mySkillsService;
        }

        public async Task<HomeIndexModelDTO> FillDashbordModel()
        {
            List<MySkills> mySkills = await _mySkillsService.GetListOfMySkills();

            List<Education> educations = await _educationService.GetListOfEducation();

            List<Experience> experiences = await _experienceService.GetListOfExperience();


            HomeIndexModelDTO model = new HomeIndexModelDTO();

            model.Experiences = experiences;
            model.Educations = educations;
            model.MySkills = mySkills;
            return model;
        }
    }
}
