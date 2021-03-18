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
    public class LanguageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<LanguageController> _localizer;
        private ILogger<LanguageController> _logger;

        public LanguageController(IUnitOfWork unitOfWork, IStringLocalizer<LanguageController> localizer, ILogger<LanguageController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Language> GetAll()
        {
            try
            {
                var allObj = _unitOfWork.Language.GetAll();
                _logger.LogInformation($"Get All Language");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all Languages");
                throw;
            };
        }

        [HttpGet("LanguageTranslated/{selectedLanguageId}")]
        public IEnumerable<Language_Translation> GetAllLanguageTranslated( int selectedLanguageId)
        {
            try
            {
                var allObj = _unitOfWork.Language.GetLanguageTranslatedBySelectedLanguage(selectedLanguageId);
                _logger.LogInformation($"Get All Language By Selected Language Id");

                return allObj.ToList();
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to Get all translated Languages");
                throw;
            };
        }
    }
}
