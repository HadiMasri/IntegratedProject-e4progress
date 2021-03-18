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
    public class QuestionLearningGoalController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<QuestionLearningGoalController> _localizer;
        private ILogger<QuestionLearningGoalController> _logger;

        public QuestionLearningGoalController(IUnitOfWork unitOfWork, IStringLocalizer<QuestionLearningGoalController> localizer, ILogger<QuestionLearningGoalController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }


        [HttpGet("{id}")]
        public List<Question_Learninggoal> GetOneById(int Id)
        {
            try
            {
                var item = _unitOfWork.Question_Learninggoal.GetLearningGoalByQuestionId(Id).ToList();

                return item;
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to Get question learning goal by id");
                throw;
            }
            
        }


        [HttpPost]
        public IActionResult Upsert(Question_Learninggoal question_Learninggoal)
        {
            try
            {
                if (question_Learninggoal.Id == 0)
                {
                    _unitOfWork.Question_Learninggoal.Add(question_Learninggoal);
                    _logger.LogInformation($"Question_Learninggoal added successfully ! ");
                }
                else
                {
                    _unitOfWork.Question_Learninggoal.Update(question_Learninggoal);
                    _logger.LogInformation($"Question_Learninggoal updated successfully ! ");
                }
                _unitOfWork.Save();

                return Json(new { success = true, message = " Added Successful" });
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to add or update question learning goal");
                throw;
            }
           
        }
    }
}
