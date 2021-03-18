using System;
using System.Collections.Generic;
using System.Linq;
using E4Progress.DAL.Entities;
using E4Progress.DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace E4Progress.Service.Controllers
{
    [Route("{culture:culture}/api/[controller]")]
    [ApiController]
    public class QuestionTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<QuestionTypeController> _localizer;
        private ILogger<QuestionTypeController> _logger;

        public QuestionTypeController(IUnitOfWork unitOfWork, IStringLocalizer<QuestionTypeController> localizer, ILogger<QuestionTypeController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<QuestionType> GetAll()
        {
            try
            {
                var allObj = _unitOfWork.Question_Type.GetAll();
                _logger.LogInformation($"Get All Question Types");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all Question Types");
                throw;
            };
        }

        [HttpGet("LanguageTranslated/{selectedLanguageId}")]
        public IEnumerable<QuestionType_Translation> GetAllQuestionTypesTranslated(int selectedLanguageId)
        {
            try
            {
                var allObj = _unitOfWork.Question_Type.GetQuestionTypeTranslatedBySelectedLanguage(selectedLanguageId);
                _logger.LogInformation($"Get All Question types By Selected Language Id");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all translated Question Types");
                throw;
            };
        }
    } 
}
