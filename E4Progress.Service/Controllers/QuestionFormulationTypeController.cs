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
    public class QuestionFormulationTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<QuestionFormulationTypeController> _localizer;
        private ILogger<QuestionFormulationTypeController> _logger;

        public QuestionFormulationTypeController(IUnitOfWork unitOfWork, IStringLocalizer<QuestionFormulationTypeController> localizer, ILogger<QuestionFormulationTypeController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Question_Formulation_Type> GetAll()
        {
            try
            {
                var allObj = _unitOfWork.Question_Formulation_Type.GetAll();
                _logger.LogInformation($"Get All Question Formulation Types");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all Question Formulation Types");
                throw;
            };
        }

        [HttpGet("LanguageTranslated/{selectedLanguageId}")]
        public IEnumerable<Question_Formulation_Type_Translation> GetAllQuestionFormulationTypesTranslated(int selectedLanguageId)
        {
            try
            {
                var allObj = _unitOfWork.Question_Formulation_Type.GetQuestionFormulationTypeTranslatedBySelectedLanguage(selectedLanguageId);
                _logger.LogInformation($"Get All Question formulation types By Selected Language Id");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all translated Question formulation Types");
                throw;
            };
        }
    }
}
