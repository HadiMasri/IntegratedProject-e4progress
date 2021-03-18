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
    public class QuestionThemaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<QuestionThemaController> _localizer;
        private ILogger<QuestionThemaController> _logger;

        public QuestionThemaController(IUnitOfWork unitOfWork, IStringLocalizer<QuestionThemaController> localizer, ILogger<QuestionThemaController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public List<Question_Content_Theme> GetOneById(int Id)
        {
            try
            {
                var item = _unitOfWork.Question_Content_Theme.GetQuestionContentThemaByQuestionId(Id).ToList();

                return item;
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to get Thema by id");
                throw;
            }
           
        }
        [HttpGet]
        public IEnumerable<Question_Content_Theme> GetAll()
        {
            try
            {
                var themes = _unitOfWork.Question_Content_Theme.GetAll();

                return themes.ToList();
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to get all Themas");
                throw;
            }
            
        }


        [HttpPost]
        public IActionResult Upsert(Question_Content_Theme questionThema)
        {
            try
            {
                if (questionThema.Id == 0)
                {
                    _unitOfWork.Question_Content_Theme.Add(questionThema);
                    _logger.LogInformation($"NewQuestion_Content_Theme added successfully ! ");
                }
                else
                {
                    _unitOfWork.Question_Content_Theme.Update(questionThema);
                    _logger.LogInformation($"Question_Content_Theme updated successfully ! ");
                }
                _unitOfWork.Save();

                return Json(new { success = true, message = " Added Successful" });
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to add or update Thema");
                throw;
            }
           
        }
    }
}
