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
    public class QuestionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IStringLocalizer<QuestionController> _localizer;
        private ILogger<QuestionController> _logger;

        public QuestionController(IUnitOfWork unitOfWork, IStringLocalizer<QuestionController> localizer, ILogger<QuestionController> logger)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Question> GetAll(string CourseName, string OfficeApp, int? UserLanguageId, int? InstructionLanguageId)
        {
            try
            {
                if (CourseName != null)
                {
                    var allObj = _unitOfWork.Question.GetAll(I => I.Instruction_Language, a => a.Office_Application, c => c.UserInterface_Language, f => f.Question_Formulation_Type, v => v.Question_Type);
                    return allObj.ToList();
                }
                else if (OfficeApp != null)
                {
                    var allObj = _unitOfWork.Question.GetAll(I => I.Instruction_Language, a => a.Office_Application, c => c.UserInterface_Language, f => f.Office_Application.Name == OfficeApp);
                    return allObj.ToList();
                }
                else if (UserLanguageId != null)
                {
                    var allObj = _unitOfWork.Question.GetAll(I => I.Instruction_Language, a => a.Office_Application, c => c.UserInterface_Language, f => f.UserInterface_Language.Id == UserLanguageId);
                    return allObj.ToList();
                }
                else if (InstructionLanguageId != null)
                {
                    var allObj = _unitOfWork.Question.GetAll(I => I.Instruction_Language, a => a.Office_Application, c => c.UserInterface_Language, f => f.Instruction_Language.Id == InstructionLanguageId);
                    return allObj.ToList();
                }
                else
                {
                    var allObj = _unitOfWork.Question.GetAll(I => I.Instruction_Language, a => a.Office_Application, c => c.UserInterface_Language, f => f.Question_Formulation_Type, v => v.Question_Type);
                    return allObj.ToList();
                }
            }
            catch (Exception)
            {
                _logger.LogError($"An error occurred while trying to get all Questions");
                throw;
            }

        }

        [HttpPost]
        public IActionResult Upsert(Question question)
        {
            try
            {
                if (question.Id == 0)
                {
                    _unitOfWork.Question.Add(question);
                    _logger.LogInformation($"New Course added successfully ! ");
                }
                else
                {
                    _unitOfWork.Question.Update(question);
                    _logger.LogInformation($"Course updated successfully ! ");
                }

                _unitOfWork.Save();
                return Json(new { success = true, message = " Added Successful" });
            }
            catch (Exception)
            {

                _logger.LogError($"An error occurred while trying to Add or update Question");
                throw;
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
                _unitOfWork.Question.Remove(Id);
                _unitOfWork.Save();
                return Json(new { success = true, message = " Delete Successful" });
        }
    }
}
