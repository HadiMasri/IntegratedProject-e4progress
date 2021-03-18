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
    public class DidacticalModelLevelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<DidacticalModelLevelController> _localizer;
        private ILogger<DidacticalModelLevelController> _logger;

        public DidacticalModelLevelController(IUnitOfWork unitOfWork, IStringLocalizer<DidacticalModelLevelController> localizer, ILogger<DidacticalModelLevelController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Didactical_Model_Level> GetAll()
        {
            try
            {
                var allObj = _unitOfWork.Didactical_Model_Level.GetAll();
                _logger.LogInformation($"Get All Model Levels Types");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all Model Levels ");
                throw;
            };
        }

        [HttpGet("LanguageTranslated/{selectedLanguageId}")]
        public IEnumerable<Didactical_Model_Level_Translation> GetAllQuestionTypesTranslated(int selectedLanguageId)
        {
            try
            {
                var allObj = _unitOfWork.Didactical_Model_Level.GetModelLevelTranslatedBySelectedLanguage(selectedLanguageId);
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
