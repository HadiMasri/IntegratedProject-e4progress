using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class QuestionPreKnowledgeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<QuestionPreKnowledgeController> _localizer;
        private ILogger<QuestionPreKnowledgeController> _logger;

        public QuestionPreKnowledgeController(IUnitOfWork unitOfWork, IStringLocalizer<QuestionPreKnowledgeController> localizer, ILogger<QuestionPreKnowledgeController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public List<Question_Pre_Knowledge_Skill> GetOneById(int Id)
        {
            try
            {
                var item = _unitOfWork.Question_Pre_Knowledge_Skill.GetPreKnowledgeSkillByQuestionId(Id).ToList();

                return item;
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to get Pre Knowledge Skill by Id");
                throw;
            }
           
        }
        [HttpGet]
        public IEnumerable<Question_Pre_Knowledge_Skill> GetAll()
        {
            try
            {
                var question_Pre_s = _unitOfWork.Question_Pre_Knowledge_Skill.GetAll();

                return question_Pre_s.ToList();
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to get All Pre Knowledge Skill");
                throw;
            }
           
        }


        [HttpPost]
        public IActionResult Upsert(Question_Pre_Knowledge_Skill question_Pre_Knowledge)
        {
            try
            {
                if (question_Pre_Knowledge.Id == 0)
                {
                    _unitOfWork.Question_Pre_Knowledge_Skill.Add(question_Pre_Knowledge);
                    _logger.LogInformation($"Question_Pre_Knowledge added successfully ! ");
                }
                else
                {
                    _unitOfWork.Question_Pre_Knowledge_Skill.Update(question_Pre_Knowledge);
                    _logger.LogInformation($"Question_Pre_Knowledge updated successfully ! ");
                }
                _unitOfWork.Save();

                return Json(new { success = true, message = " Added Successful" });
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to add or update  Pre Knowledge Skill");
                throw;
            }
            
        }
    }
}
